using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CyUSB;
using System.IO; // txt 파일 사용용
using System.IO.Ports;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM : Form
    {

        //DISTANCE CONTROL VALUE
        volatile string get_x_move;               //get text from formbox
        volatile string param_x_move;           //set parameter
        volatile int x_move_distance;            //convert x-move distance

        volatile string get_y_move;              //get text from formbox
        volatile string param_y_move;          //set parameter
        volatile int y_move_distance;           //convert y-move distance

        volatile string get_z_move;              //get text from formbox
        volatile string param_z_move;          //set parameter
        volatile int z_move_distance;           //convert z-move distance

        //SPEED CONTROL VALUE
        volatile string Send_Speed;
        volatile string get_key_speed;               //get keyboard control speed
        volatile string get_auto_speed;             //get auto control speed


        volatile int x; //set X-axis value
        volatile string y;  //set Y-axis value
        volatile string send_data = ""; //Serial Tx Data
        volatile bool flag_a = true; //Key board Control Sequential Value (KeyDown => KeyRelease)

        SerialPort sPort; // Init SerialPort
        Thread data_request; // Init SerialPort Receive Data Split Proccess Thread


        private void StageControlInit()
        {
            StageControlPage1.Enabled = false;
            this.sPort = new SerialPort();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(Main_KeyRelease);
            this.KeyDown += new KeyEventHandler(Main_Keydown);

            X_measure.Text = "μm";//3D stage control distance measurement
            Y_measure.Text = "μm";//3D stage control distance measurement
            Z_measure.Text = "μm";//3D stage control distance measurement

            KeySpeed_combo.Text = "Normal";
            AutoSpeed_combo.Text = "Normal";

            cboCOMPort.BeginUpdate();

            foreach (string comport in SerialPort.GetPortNames())
            {
                cboCOMPort.Items.Add(comport);
            }
            cboCOMPort.EndUpdate();

            cboCOMPort.SelectedItem = Properties.Settings.Default.COMPORT;
            CheckForIllegalCrossThreadCalls = false;

        }

        //Serial Port Connection Init---------------------------------------------------------------------------------------------------------------
        private void Stage_Connect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.COMPORT = cboCOMPort.Text;
            Properties.Settings.Default.Save();
            try
            {
                if (sPort.IsOpen)
                {
                    data_requeset_thread_stop();
                    Stage_Connect.Text = "Connect";
                    Stage_label.Text = "Stage Disconnected";

                    if (sPort != null)
                    {
                        sPort.Close();
                        sPort.Dispose();
                        sPort = new SerialPort();
                    }

                    StageControlPage1.Enabled = false;
                }
                else
                {
                    StageControlPage1.Enabled = true;
                    Stage_Connect.Text = "Disconnect";
                    Stage_label.Text = "Stage Connected";

                    sPort.DataReceived += new SerialDataReceivedEventHandler(SPort_DataReceived);
                    sPort.PortName = cboCOMPort.SelectedItem.ToString();
                    sPort.BaudRate = 9600;
                    sPort.DataBits = (int)8;
                    sPort.Parity = Parity.None;
                    sPort.StopBits = StopBits.One;
                    sPort.ReadTimeout = (int)500;
                    sPort.WriteTimeout = (int)500;
                    sPort.Handshake = Handshake.RequestToSend;
                    sPort.Open();
                    data_request_thread_start();


                }

            }
            catch (System.Exception ex)
            {
                ShowAlertMessage(ex);
            }
        }


        //Serial Port Data Receive---------------------------------------------------------------------------------------------------------------
        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string iRecSize = sPort.ReadExisting();
            this.Invoke(new EventHandler(delegate
            {
                if (string.Format("{0}", iRecSize).Length > 10)
                {
                    try
                    {
                        y = (string.Format("{0}", iRecSize).Substring(0, 10)).Replace(" ", "");
                        x = Convert.ToInt32(y);
                        X_pos_lab.Text = Convert.ToString(x);

                        y = (string.Format("{0}", iRecSize).Substring(11, 10)).Replace(" ", "");
                        x = Convert.ToInt32(y);
                        Y_pos_lab.Text = Convert.ToString(x);

                        y = (string.Format("{0}", iRecSize).Substring(22, 10)).Replace(" ", "");
                        x = Convert.ToInt32(y);
                        Z_pos_lab.Text = Convert.ToString(x);
                    }
                    catch (Exception ex)
                    {
                        ShowAlertMessage(ex);
                    }
                }
                else
                {
                    Recbox.Text += string.Format("{0}", iRecSize); ;
                }
            }));


        }


        //Serial Port Receive Data Split Proccess Thread---------------------------------------------------------------------------------------------------------------
        public void data_request_thread()
        {
            while (true)
            {
                /***************** This Thread Sleep Time is important Value ********************/
                Thread.Sleep(300);  // Recommended speed > 300
                // This Value set Data Receive cycle from Stage Controller to Desktop Software 
                /************************************************************************************/
                try
                {
                    if (send_data != "")
                    {
                        sPort.Write(send_data);
                        send_data = "";
                    }
                    else
                    {
                        sPort.Write("q:\r\n");
                    }
                }
                catch (Exception ex)
                {
                    ShowAlertMessage(ex);
                }
            }
        }

        public void data_request_thread_start()
        {
            data_request = new Thread(new ThreadStart(data_request_thread));
            data_request.IsBackground = true;
            data_request.Priority = ThreadPriority.Lowest;
            data_request.Start();
        }

        public void data_requeset_thread_stop()
        {
            if (data_request.IsAlive)
            {
                data_request.Abort();
                data_request = null;
            }
        }



        //STAGE EMERGENCY STOP CONTROL BTN---------------------------------------------------------------------------------------------------------------
        private void Stage_stop_bt_Click(object sender, EventArgs e)
        {
            //L: E command = Emergency stop : This command stops all stages immediately, whatever the conditions.
            Recbox.Clear();
            if (sPort.IsOpen)
            {
                send_data = "L:E\r\n";
            }
        }



        //STAGE Origin Point CONTROL BTN---------------------------------------------------------------------------------------------------------------
        private void Stage_set_origin_bt_Click(object sender, EventArgs e)
        {
            //R command = Return to electronic (logic) origin : When this command is executed, the stage decelerates and stops.
            Recbox.Clear();
            if (sPort.IsOpen)
            {
                flag_a = false;
                send_data = "r:w\r\ng:\r\n";
            }

        }

        private void Stage_move_origin_bt_Click(object sender, EventArgs e)
        {
            //A command = Set number of pulses for absolute travel : Features: This command is to specify the axis of travel, direction, and the travel (number of pulses).
            Recbox.Clear();
            if (sPort.IsOpen)
            {
                flag_a = false;
                send_data = "a:w+p0+p0+p0\r\ng:\r\n";
            }

        }



        //STAGE SPEED CONTROL---------------------------------------------------------------------------------------------------------------
        private void KeySpeed_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KeySpeed_combo
            if (!KeySpeed_combo.Text.Equals("Custom"))
            {
                KeySpeed_custom.Enabled = false;
                switch (KeySpeed_combo.Text)
                {
                    case "Super Low":
                        KeySpeed_custom.Text = "1000";
                        break;

                    case "Low":
                        KeySpeed_custom.Text = "3000";
                        break;

                    case "Normal":
                        KeySpeed_custom.Text = "5000";
                        break;

                    case "High":
                        KeySpeed_custom.Text = "8000";
                        break;

                    case "Super High":
                        KeySpeed_custom.Text = "10000";
                        break;

                }

                Console.WriteLine("Set KeySpeed Custom Mode");
            }
            else
            {
                KeySpeed_custom.Enabled = true;
            }
        }

        private void AutoSpeed_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KeySpeed_combo
            if (!AutoSpeed_combo.Text.Equals("Custom"))
            {
                AutoSpeed_custom.Enabled = false;
                switch (AutoSpeed_combo.Text)
                {
                    case "Super Low":
                        AutoSpeed_custom.Text = "1000";
                        break;

                    case "Low":
                        AutoSpeed_custom.Text = "3000";
                        break;

                    case "Normal":
                        AutoSpeed_custom.Text = "5000";
                        break;

                    case "High":
                        AutoSpeed_custom.Text = "8000";
                        break;

                    case "Super High":
                        AutoSpeed_custom.Text = "10000";
                        break;

                }

                Console.WriteLine("AutoSpeed Combo EventChange : " + AutoSpeed_custom.Text);
            }
            else
            {
                AutoSpeed_custom.Enabled = true;
                Console.WriteLine("Set AutoSpeed Custom Mode");
            }
        }

        private void Stage_speed_control_bt_Click(object sender, EventArgs e)
        {
            Recbox.Clear();

            get_key_speed = KeySpeed_custom.Text;
            get_auto_speed = AutoSpeed_custom.Text;

            if (sPort.IsOpen)
            {
                Send_Speed = "D:1" + "S" + get_key_speed + "F" + get_auto_speed + "R500\r\n"
                                    + "D:2" + "S" + get_key_speed + "F" + get_auto_speed + "R500\r\n"
                                    + "D:3" + "S" + get_key_speed + "F" + get_auto_speed + "R500\r\n";

                send_data = Send_Speed;
            }

            Console.WriteLine("Speed Send :: Keyboard Control : " + get_key_speed + " / Auto Control : " + get_auto_speed);
        }



        //STAGE DISTANCE CONTROL---------------------------------------------------------------------------------------------------------------
        private void total_move_bt_Click(object sender, EventArgs e)
        {
            //M command = Set number of pulses for relative travel : This command is to specify the axis of travel, direction, and the travel (number of pulses).
            Recbox.Clear();
            //absolute travel
            get_x_move = X_dist_pos.Text;
            get_y_move = Y_dist_pos.Text;
            get_z_move = Z_dist_pos.Text;

            x_move_distance = Convert.ToInt32(get_x_move);
            y_move_distance = Convert.ToInt32(get_y_move);
            z_move_distance = Convert.ToInt32(get_z_move);

            /* x distance */
            if (x_move_distance >= 0)
            {
                param_x_move = "+p";
            }
            else
            {
                param_x_move = "-p";
            }
            switch (X_measure.Text)
            {
                case "cm":
                    x_move_distance = x_move_distance * 10000;
                    break;

                case "mm":
                    x_move_distance = x_move_distance * 1000;
                    break;

                case "μm":
                    x_move_distance = x_move_distance;
                    break;
            }


            /* y distance */
            if (y_move_distance >= 0)
            {
                param_y_move = "+p";
            }
            else
            {
                param_y_move = "-p";
            }
            switch (Y_measure.Text)
            {
                case "cm":
                    y_move_distance = y_move_distance * 10000;
                    break;

                case "mm":
                    y_move_distance = y_move_distance * 1000;
                    break;

                case "μm":
                    y_move_distance = y_move_distance;
                    break;
            }

            /* z distance */
            if (z_move_distance >= 0)
            {
                param_z_move = "+p";
            }
            else
            {
                param_z_move = "-p";
            }
            switch (Z_measure.Text)
            {
                case "cm":
                    z_move_distance = z_move_distance * 10000;
                    break;

                case "mm":
                    z_move_distance = z_move_distance * 1000;
                    break;

                case "μm":
                    z_move_distance = z_move_distance;
                    break;
            }
            get_x_move = Convert.ToString(x_move_distance);

            get_y_move = Convert.ToString(y_move_distance);

            get_z_move = Convert.ToString(z_move_distance);

            if (sPort.IsOpen)
            {
                send_data = "m:w" + param_x_move + get_x_move.Replace("-", "") + param_y_move + get_y_move.Replace("-", "") + param_z_move + get_z_move.Replace("-", "") + "\r\ng:\r\n";
            }
            Console.WriteLine("Total-Move: " + send_data);

        }

        private void X_dist_bt_Click(object sender, EventArgs e)
        {
            Recbox.Clear();
            // X distance
            get_x_move = X_dist_pos.Text;
            x_move_distance = Convert.ToInt32(get_x_move);

            if (x_move_distance >= 0)
            {
                param_x_move = "+p";
            }
            else
            {
                param_x_move = "-p";
            }

            switch (X_measure.Text)
            {
                case "cm":
                    x_move_distance = x_move_distance * 10000;
                    break;

                case "mm":
                    x_move_distance = x_move_distance * 1000;
                    break;

                case "μm":
                    x_move_distance = x_move_distance;
                    break;
            }
            get_x_move = Convert.ToString(x_move_distance);

            if (sPort.IsOpen)
            {
                send_data = "m:1" + param_x_move + get_x_move.Replace("-", "") + "\r\ng:\r\n";
            }
            Console.WriteLine("X-Move: " + send_data);
        }

        private void Y_dist_bt_Click(object sender, EventArgs e)
        {
            Recbox.Clear();
            // Y distance
            get_y_move = Y_dist_pos.Text;
            y_move_distance = Convert.ToInt32(get_y_move);

            if (y_move_distance >= 0)
            {
                param_y_move = "+p";
            }
            else
            {
                param_y_move = "-p";
            }

            switch (Y_measure.Text)
            {
                case "cm":
                    y_move_distance = y_move_distance * 10000;
                    break;

                case "mm":
                    y_move_distance = y_move_distance * 1000;
                    break;

                case "μm":
                    y_move_distance = y_move_distance;
                    break;
            }
            get_y_move = Convert.ToString(y_move_distance);

            if (sPort.IsOpen)
            {
                send_data = "m:2" + param_y_move + get_y_move.Replace("-", "") + "\r\ng:\r\n";
            }
            Console.WriteLine("Y-Move: " + send_data);
        }

        private void Z_dist_bt_Click(object sender, EventArgs e)
        {
            Recbox.Clear();
            // Z distance
            get_z_move = Z_dist_pos.Text;
            z_move_distance = Convert.ToInt32(get_z_move);

            if (z_move_distance >= 0)
            {
                param_z_move = "+p";
            }
            else
            {
                param_z_move = "-p";
            }

            switch (Z_measure.Text)
            {
                case "cm":
                    z_move_distance = z_move_distance * 10000;
                    break;

                case "mm":
                    z_move_distance = z_move_distance * 1000;
                    break;

                case "μm":
                    z_move_distance = z_move_distance;
                    break;
            }
            get_z_move = Convert.ToString(z_move_distance);

            if (sPort.IsOpen)
            {
                send_data = "m:3" + param_z_move + get_z_move.Replace("-", "") + "\r\ng:\r\n";
            }
            Console.WriteLine("Z-Move: " + send_data);
        }



        // KEY DOWN COMMAND---------------------------------------------------------------------------------------------------------------
        private void Main_Keydown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("key donw");
            //keyboard control
            //J command = JOG  : This command drives stages continuously (at a constant speed) at the starting speed (S).
            Recbox.Clear();
            try
            {
                if (sPort.IsOpen)
                {
                    if (e.Control && (e.KeyValue == 104 || e.KeyValue == 38) && flag_a)//Y up
                    {
                        flag_a = false;
                        send_data = "j:2+\r\ng:\r\n";
                    }
                    else if (e.Control && (e.KeyValue == 98 || e.KeyValue == 40) && flag_a)//Y down
                    {
                        flag_a = false;
                        send_data = "j:2-\r\ng:\r\n";
                    }
                    else if (e.Control && (e.KeyValue == 102 || e.KeyValue == 39) && flag_a)//X up
                    {
                        flag_a = false;
                        send_data = "j:1+\r\ng:\r\n";
                    }
                    else if (e.Control && (e.KeyValue == 100 || e.KeyValue == 37) && flag_a)//X down
                    {
                        flag_a = false;
                        send_data = "j:1-\r\ng:\r\n";
                    }
                    else if ((e.Control && e.KeyValue == 109) || (e.Alt && e.KeyValue == 38) && flag_a)//z up
                    {
                        flag_a = false;
                        send_data = "j:3+\r\ng:\r\n";
                    }
                    else if ((e.Control && e.KeyValue == 107) || (e.Alt && e.KeyValue == 40) && flag_a)//z down
                    {
                        flag_a = false;
                        send_data = "j:3-\r\ng:\r\n";
                    }
                    else if (((e.Control && e.KeyValue == 101) || (e.Alt && e.KeyValue == 13)) && flag_a)//set  custom origin point
                    {
                        flag_a = false;
                        send_data = "r:w\r\ng:\r\n";
                        Console.WriteLine("Key Command : Set Custom Orgin Point");
                    }
                    else if (((e.Control && e.KeyValue == 106) || (e.Alt && (e.KeyValue == 36 || e.KeyValue == 104))) && flag_a)//go to set zero =  Ctrl + *  / Alt + HOME or H orgo to custom origin point
                    {
                        flag_a = false;
                        send_data = "a:w+p0+p0+p0\r\ng:\r\n";
                        Console.WriteLine("Key Command : Go to Custom Orgin Point");

                    }
                    else if (e.Alt && (e.KeyValue == 111 || e.KeyValue == 191 || e.KeyValue == 114) && flag_a)//org key = Ctrl + / (TenKey) or Alt + / (MainKey) or R  = go to system origin point
                    {
                        flag_a = false;
                        send_data = "h:w\r\ng:\r\n";
                        Console.WriteLine("Key Command : Stage System Reset(Go to System Zero Point(0,0,0)");
                    }
                    else if ((e.Alt && (e.KeyValue == 27 || e.KeyValue == 35)) && flag_a)//stage emergency stop = Alt + Esc or END  = STOP movement
                    {
                        flag_a = false;
                        send_data = "L:E\r\n";
                        Console.WriteLine("Key Command : Stage Emergency Stop");
                    }

                }
            }
            catch (Exception ex)
            {
                ShowAlertMessage(ex);
            }
        }


        // KEY Release COMMAND---------------------------------------------------------------------------------------------------------------
        private void Main_KeyRelease(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("key Release");
            //keyboard control
            //L command = Decelerate and stop : When this command is executed, the stage decelerates and stops.
            try
            {

                if (sPort.IsOpen)
                {
                    if (e.Control && (e.KeyValue == 104 || e.KeyValue == 38))//Y up
                    {

                        send_data = "L:2\r\nq:\r\n";
                        flag_a = true;

                    }
                    else if (e.Control && (e.KeyValue == 98 || e.KeyValue == 40))//Y down
                    {

                        send_data = "L:2\r\nq:\r\n";
                        flag_a = true;
                    }
                    else if (e.Control && (e.KeyValue == 102 || e.KeyValue == 39))//X up
                    {

                        send_data = "L:1\r\nq:\r\n";
                        flag_a = true;
                    }
                    else if (e.Control && (e.KeyValue == 100 || e.KeyValue == 37))//X down
                    {

                        send_data = "L:1\r\nq:\r\n";
                        flag_a = true;
                    }
                    else if ((e.Control && e.KeyValue == 109) || (e.Alt && e.KeyValue == 38))//Z up                    
                    {

                        send_data = "L:3\r\nq:\r\n";
                        flag_a = true;
                    }
                    else if ((e.Control && e.KeyValue == 107) || (e.Alt && e.KeyValue == 40))//Z down
                    {
                        send_data = "L:3\r\nq:\r\n";
                        flag_a = true;
                    }
                    else
                    {
                        flag_a = true;
                    }
                }

            }
            catch (Exception ex)
            {
                ShowAlertMessage(ex);
            }

        }

        //TRIGGER CONTROL---------------------------------------------------------------------------------------------------------------
        private void trigger_init_Click(object sender, EventArgs e)
        {
            send_data = "t:m" + "\r\n";  //First point trigger signal generate.
            flag_a = true;

            Console.WriteLine("Trigger Test : " + send_data);

        }

        private void Stage_speed_bt_Click(object sender, EventArgs e)
        {
            Stage_speed_control_bt_Click(sender, e);
        }

        private void Btn_set_origin_Click(object sender, EventArgs e)
        {
            Stage_set_origin_bt_Click(sender, e);
        }

        private void Btn_move_origin_Click(object sender, EventArgs e)
        {
            Stage_move_origin_bt_Click(sender, e);
        }

        private void XYZ_dist_bt_Click(object sender, EventArgs e)
        {
            total_move_bt_Click(sender, e);
        }


        private void galvo_Reset_Click(object sender, EventArgs e)
        {
            SendParameterReset();
            CH1_SCANInterface(true);

            setSaveDataFlag = false;

            /*Draw Reset*/
            if (graphicDrawThread != null)
            {
                graphicDrawThread.Abort();
                graphicDrawThread.Join();
                graphicDrawThread = null;
                GraphicImagingDataReset();

            }

            send_data = "a:w+p0+p0+p0\r\ng:\r\n";

            MessageBox.Show("초기화 되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void galvo_Set_Click(object sender, EventArgs e)
        {
            try
            {
                SendParameterReset();
                CH1_ReisterSet();

                String _8412_triggermode_EN = "84120001";
                Tx_data[RegisterSequencyCounter] = int.Parse(_8412_triggermode_EN, styleHex); RegisterSequencyCounter++;
                String _8416_laser_wait = "841600C7";
                Tx_data[RegisterSequencyCounter] = int.Parse(_8416_laser_wait, styleHex); RegisterSequencyCounter++;
                String _8420_laser_PRF_L = "84200D3F";
                Tx_data[RegisterSequencyCounter] = int.Parse(_8420_laser_PRF_L, styleHex); RegisterSequencyCounter++;
                String _8421_laser_PRF_H = "84210003";
                Tx_data[RegisterSequencyCounter] = int.Parse(_8421_laser_PRF_H, styleHex); RegisterSequencyCounter++;
                String _8422_laser_scanline = "842203E7";
                Tx_data[RegisterSequencyCounter] = int.Parse(_8422_laser_scanline, styleHex); RegisterSequencyCounter++;

                GraphicImagingDataReset();
                //*/ Test Data
                //*/
                writeSendFlag = true;


                //*/ DrawThread Star
                if (graphicDrawThread == null)
                {
                    graphicDrawThread = new Thread(new ThreadStart(DrawThread));
                    graphicDrawThread.IsBackground = true;
                    graphicDrawThread.Priority = ThreadPriority.Normal;
                    graphicDrawThread.Start();
                }
                //*/

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exepction : {0}", ex);
            }
        }

        private void galvo_Start_Click(object sender, EventArgs e)
        {
            streamWriter = new StreamWriter(Application.StartupPath + @"\data\temp_data.txt");

            Recbox.Clear();
            // X distance
            x_move_distance = 4 * 10000; // cm = 10000 / mm = 1000 /  μm = 1;

            if (x_move_distance >= 0)
            {
                param_x_move = "+p";
            }
            else
            {
                param_x_move = "-p";
            }

            get_x_move = Convert.ToString(x_move_distance);

            if (sPort.IsOpen)
            {
                send_data = "t:m" + "\r\n" + "m:1" + param_x_move + get_x_move.Replace("-", "") + "\r\ng:\r\n";
            }
            Console.WriteLine("Galvo X-Move: " + send_data);

            setSaveDataFlag = true;

        }



        public void ShowAlertMessage(Exception ex)
        {
            DialogResult result = MessageBox.Show("연결이 올바르지 않습니다.\r\n" + ex.Message + "\r\n프로그램을 재실행해주시기 바랍니다.\r\n", "프로그램 연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                //Console.WriteLine("Show Alert Enter Key Event");
                Environment.Exit(Environment.ExitCode);

            }


        }
    }

}
