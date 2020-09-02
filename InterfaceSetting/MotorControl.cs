using CSdllMightyZap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {

        MightyZap MZap = new MightyZap();
        string PortName;
        string BaudRate;
        int BaudRate_Data;
        int MZapTemp;
        byte ServoID;
        short Position;
        int PresentPosition_Data;
        int SetMovingPosition_Data;

        Thread motor_scan;
        Thread motor_loop;

        //*/Rotaion Motor Control SET
        string _A402_0010 = null;
        string _A403_0063 = null;
        string _A404_C34F = null;
        string _A405_DIRE = null;
        string _A400_0001 = null;
        string _A400_0000 = null;

        private void MotorControlInit()
        {
            //*/ Comport Auto Set
            motor_Comport.BeginUpdate();
            foreach (string comport in SerialPort.GetPortNames())
            {
                motor_Comport.Items.Add(comport);
            }
            motor_Comport.EndUpdate();
            //*/

            //*/ Motor Parameter Init
            motor_ServoID.Text = "3";
            BaudRate = "57600";
            BaudRate_Data = Convert.ToInt32(BaudRate);
            motor_Comport.SelectedItem = "COM25";
        }

        private void motor_Comport_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                PortName = motor_Comport.SelectedItem as string;
                Console.WriteLine(String.Format("PortName: {0}", PortName));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }

        private void motor_ServoID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ServoID = Byte.Parse(motor_ServoID.Text);
                Console.WriteLine(String.Format("ServoID: {0:D}", ServoID));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }
        private void motor_PresentPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PresentPosition_Data = int.Parse(string.Format("{0:D}", motor_PresentPosition.Text), styleInteger);
                Console.WriteLine(String.Format("Present Position: {0:D}", PresentPosition_Data));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }

        private void motor_MovingPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Position = (short)Convert.ToInt16(motor_MovingPosition.Text.ToString());
                Console.WriteLine(String.Format("Position: {0:D}", Position));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : {0}", ex);
            }
        }

        /* 
         * 
         * Motor Tab Button Control 
         *
         */

        //*/ Linear Motor
        private void motor_ConnectionControl_Click(object sender, EventArgs e)
        {
            Motor_ConnectionInterface(MotorConnection_Loop);
            if (MotorConnection_Loop)
            {
                MZap.OpenMightyZap(PortName, BaudRate_Data);
                MZapTemp = MZap.read_Addr(ServoID, 140, 2);
                motor_PresentPosition.Clear();
                motor_MovingPosition.Clear();
                motor_PresentPosition.Text = MZapTemp.ToString();
                motor_MovingPosition.Text = MZapTemp.ToString();
                groupBox_motorPositionInfo.Enabled = true;
            }
            else
            {
                MZap.CloseMightyZap();
                motor_PresentPosition.Clear();
                motor_MovingPosition.Clear();
                groupBox_motorPositionInfo.Enabled = false;
            }
        }

        private void motor_PositionCheck_Click(object sender, EventArgs e)
        {
            motor_PresentPosition.Clear();
            motor_PresentPosition.Text = MZap.presentPosition(ServoID).ToString();
        }

        private void motor_PositionReset_Click(object sender, EventArgs e)
        {
            Motor_PositionResetFunc();
        }

        private void motor_PositionSet_Click(object sender, EventArgs e)
        {
            MZap.goalPosition(ServoID, Position);
        }


        //*/ Linear Motor

        private void linear_positionMove_Click(object sender, EventArgs e)
        {

        }


        //*/ Rotation Motor
        bool roation_Loop = false;
        private void RotationMotorControl_HIFU_Click(object sender, EventArgs e)
        {
            if (!roation_Loop)
            {
                roation_Loop = true;
                SendParameterReset();

                _A402_0010 = "A4020000";
                _A403_0063 = "A4030063";
                _A404_C34F = "A404C34F";
                _A405_DIRE = "A4050001";
                _A400_0001 = "A4000001";
                _A400_0000 = "A4000000";
                Tx_data[RegisterSequencyCounter] = int.Parse(_A402_0010, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A403_0063, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A404_C34F, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A405_DIRE, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A400_0001, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A400_0000, styleHex); RegisterSequencyCounter++;

                writeSendFlag = true;
            }
            
        }

        private void RotationMotorControl_Imaging_Click(object sender, EventArgs e)
        {
            if (roation_Loop)
            {
                roation_Loop = false;
                SendParameterReset();

                _A402_0010 = "A4020000";
                _A403_0063 = "A4030063";
                _A404_C34F = "A404C34F";
                _A405_DIRE = "A4050000";
                _A400_0001 = "A4000001";
                _A400_0000 = "A4000000";
                Tx_data[RegisterSequencyCounter] = int.Parse(_A402_0010, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A403_0063, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A404_C34F, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A405_DIRE, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A400_0001, styleHex); RegisterSequencyCounter++;
                Tx_data[RegisterSequencyCounter] = int.Parse(_A400_0000, styleHex); RegisterSequencyCounter++;

                writeSendFlag = true;
            }

        }


        /* 
         * 
         * Motro Tab Button Function 
         * 
         */

        bool MotorConnection_Loop = false;
        public void Motor_ConnectionInterface(bool ClickCheck)
        {
            if (ClickCheck == false)
            {
                motor_ConnectionControl.Text = "Connected";
                motor_ConnectionControl.BackColor = Color.FromArgb(64, 64, 64);
                MotorConnection_Loop = true;
            }
            else if (ClickCheck == true)
            {
                motor_ConnectionControl.Text = "Connect";
                motor_ConnectionControl.BackColor = Color.Black;
                MotorConnection_Loop = false;
            }
        }

        bool MotorMoving_Loop = false;
        public void Motor_MovingInterface(bool ClickCheck)
        {
            if(!MotorConnection_Loop)
            {
                Console.WriteLine("Please Motor Connection Check");
            }
            else
            {
                if (ClickCheck == false)
                {
                    Position = (short)Convert.ToInt16("2000");
                    MZap.goalPosition(ServoID, Position);
                    MotorMoving_Loop = true;
                }
                else if (ClickCheck == true)
                {
                    MZap.goalPosition(ServoID, 0);
                    MotorMoving_Loop = false;
                }
            }

        }

        public void Motor_PositionResetFunc()
        {

            if (!MotorConnection_Loop)
            {
                Console.WriteLine("Please Motor Connection Check");
            }
            else
            {
                MZap.goalPosition(ServoID, 0);
                SetMovingPosition_Data = 0;
            }
        }



        bool linear_loopModeState = false;
        private void linear_loopMode_CheckedChanged(object sender, EventArgs e)
        {
            if (linear_loopMode.Checked == true)
            {
                linear_loopModeState = true;
            }
            else
            {
                linear_loopModeState = false;
            }
        }

        public void motor_scan_thread()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(100);

                    Position = MZap.presentPosition(ServoID);
                    motor_PresentPosition.Text = Position.ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Motor Scan Error : " + e);
                }


            }
        }

        public void motor_loop_thread()
        {
            while (true)
            {
                //Console.WriteLine("global_toggle : " + global_toggle);
                if (Int32.Parse(Position.ToString()) >= 1990)
                {

                    //Data_Check();

                    //Register_reset();
                    //num = 0;
                    //Tx_data[num] = Int32.Parse("84000001", System.Globalization.NumberStyles.HexNumber); num++;
                    //Tx_data[num] = Int32.Parse("84000001", System.Globalization.NumberStyles.HexNumber); num++;
                    //Tx_data[num] = Int32.Parse("84000001", System.Globalization.NumberStyles.HexNumber); num++;
                    //Tx_data[num] = Int32.Parse("84000001", System.Globalization.NumberStyles.HexNumber); num++;
                    //Tx_data[num] = Int32.Parse("84000000", System.Globalization.NumberStyles.HexNumber); num++;

                    Position = (short)Convert.ToInt16("0");
                    MZap.goalPosition(ServoID, Position);
                    Thread.Sleep(3000);

                }
                else if (Int32.Parse(Position.ToString()) <= 6)
                {

                    SendParameterReset();
                    _8400_System_On = "84000001";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;

                    _8400_System_On = "84000000";
                    Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
                    writeSendFlag = true;
                    setSaveDataFlag = true;
                    Position = (short)Convert.ToInt16("2000");
                    MZap.goalPosition(ServoID, Position);
                }


            }
        }
    }
}
