using CSdllMightyZap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
                ServoID = Byte.Parse(string.Format("{0:D}", motor_ServoID.Text), styleInteger);
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
        private void motor_ConnectionControl_Click(object sender, EventArgs e)
        {
            Motor_ConnectionInterface(MotorConnection_Loop);
            if (MotorConnection_Loop)
            {
                MZap.OpenMightyZap(PortName, BaudRate_Data);
                MZapTemp = MZap.read_Addr(ServoID, 140, 2);
                motor_PresentPosition.Clear();
                motor_MovingPosition.Clear();
                motor_PresentPosition.AppendText(MZapTemp.ToString());
                motor_MovingPosition.AppendText(MZapTemp.ToString());
            }
            else
            {
                MZap.CloseMightyZap();
            }
        }

        private void motor_PositionCheck_Click(object sender, EventArgs e)
        {
            motor_PresentPosition.Clear();
            motor_PresentPosition.AppendText(MZap.presentPosition(ServoID).ToString());
        }

        private void motor_PositionReset_Click(object sender, EventArgs e)
        {
            Motor_PositionResetFunc();
        }

        private void motor_PositionSet_Click(object sender, EventArgs e)
        {
            MZap.goalPosition(ServoID, Position);
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
                    MotorConnection_Loop = true;
                }
                else if (ClickCheck == true)
                {
                    MZap.goalPosition(ServoID, 0);
                    MotorMoving_Loop = false;
                    MotorConnection_Loop = false;
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
    }
}
