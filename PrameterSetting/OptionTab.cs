using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        /* 
         * 
         * OPTION Tab Button Control 
         *
         */
        private void Param_HexToBinarySend_Click(object sender, EventArgs e)
        {
            Param_HexToBinarySendFunction();
        }

        private void Param_ScanlineCounterSet_Click(object sender, EventArgs e)
        {
            Param_ScanlineCounterSetFunction();
        }

        private void Param_ScanlineCounterSend_Click(object sender, EventArgs e)
        {
            Param_ScanlineCounterSendFunction();
        }
        private void Param_ScanlineSelectView_Click(object sender, EventArgs e)
        {
            Param_ScanlineSelectViewFunction(int.Parse(Param_ScanlineViewValue.Text));
        }

        private void Param_ScanlineTotalView_Click(object sender, EventArgs e)
        {
            Param_ScanlineTotalViewFunction();
        }


        Boolean TestDataInitTrigger = false;
        Boolean TestDataButton_Loop = false;
        private void Param_TestDataStart_Click(object sender, EventArgs e)
        {
            if (TestDataButton_Loop == false)
            {
                TestDataButton_Loop = true;
                Param_TestDataStart.Text = "TEST Stop";

                if (!TestDataInitTrigger)
                {
                    TestDataInitTrigger = true;
                    SendParameterReset();
                    SendParameterTestReset();

                }

                /* Timer Start */
                if (timer == null)
                {
                    timer_initialize();
                }
                timer.Start();
                stopWatch.Start();


                //*/ DrawThread Star
                if(graphicDrawThread == null)
                {
                    graphicDrawThread = new Thread(new ThreadStart(DrawThread));
                    graphicDrawThread.IsBackground = true;
                    graphicDrawThread.Priority = ThreadPriority.Highest;
                    graphicDrawThread.Start();
                }
                //*/
            }
            else
            {
                TestDataButton_Loop = false;
                Param_TestDataStart.Text = "TEST Start";

                //Set Timer Setting
                timer.Stop();
                //Set StopWatch
                stopWatch.Stop();
                
            }
        }

        private void Param_TestDataReset_Click(object sender, EventArgs e)
        {

            /*Parameter Reset*/
            TestDataInitTrigger = false;
            SendParameterReset();
            SendParameterTestReset();

            /*TImer Reset*/
            timer.Close();
            stopWatch.Reset();
            timSpan = new TimeSpan(0, 0, 0, 0);
            textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);

            /*Draw Reset*/
            graphicDrawThread.Abort();
            graphicDrawThread.Join();
            graphicDrawThread = null;
            GraphicImagingDataReset();

            MessageBox.Show("초기화 되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Param_ScanlineSelectTestDataView_Click(object sender, EventArgs e)
        {
            Param_ScanlineTestDataSelectViewFunction(int.Parse(Param_ScanlineTestDataViewValue.Text));
        }

        private void Param_ScanlineTotalTestDataView_Click(object sender, EventArgs e)
        {
            Param_ScanlineTestDataTotalViewFunction();
        }



        /* 
         * 
         * OPTION Tab Button Function 
         * 
         */



        //*/ Pram_HexToBinarySend()
        String HexNumber;
        int HexNumberConvert;
        String BinNumber;
        private void Param_HexToBinarySendFunction()
        {
            SendParameterReset();

            HexNumber = Param_HexNumber.Text.Replace(" ", "");
            HexNumberConvert = Int32.Parse(HexNumber, System.Globalization.NumberStyles.HexNumber);
            BinNumber = Convert.ToString(HexNumberConvert, 2);

            for (int i = 1; i < 9; i++)
            {
                BinNumber.Insert(4 * i, " ");
            }
            Param_BinaryNumber.Text = BinNumber;

            Tx_data[RegisterSequencyCounter] = HexNumberConvert;

            writeSendFlag = true;

            Console.WriteLine(String.Format("HEX : {0} / BIN : {1}", HexNumber, BinNumber));
            SystemLogBox.AppendText(String.Format("HEX : {0} / BIN : {1}", HexNumber, BinNumber) + "\r\n");

        }
        //*/
        String _8005_DebugMode;
        String ScanlineNumber;
        int ScanlineNumberConvert;

        private void Param_ScanlineCounterSetFunction()
        {
            SendParameterReset();

            ScanlineNumber = Param_ScanlineCounterValue.Text.Replace(" ", "");
            ScanlineNumberConvert = Int32.Parse(ScanlineNumber, System.Globalization.NumberStyles.HexNumber);

            _8414_ScanLine_Reset = "84140001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8414_ScanLine_Reset, styleHex); RegisterSequencyCounter++;
            _8414_ScanLine_Reset = "84140000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8414_ScanLine_Reset, styleHex); RegisterSequencyCounter++;

            _8401_Rx_Data = "84010FFF";
            _8402_PRF_L = "84021387";
            _8403_PRF_H = "84030000";
            _8413_ScanLine_Data = String.Format("8413{0}", (ScanlineNumberConvert - 1).ToString("X4"));
            _8C00_PulseLength = "8C00007A";
            _8C01_DampLength = "8C010002";
            _8C02_CycleLength = "8C020001";
            _8005_DebugMode = "80050001";

            Tx_data[RegisterSequencyCounter] = int.Parse(_8401_Rx_Data, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8402_PRF_L, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8403_PRF_H, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8413_ScanLine_Data, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C00_PulseLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C01_DampLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8C02_CycleLength, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8005_DebugMode, styleHex); RegisterSequencyCounter++;

            writeSendFlag = true;

        }
        private void Param_ScanlineCounterSendFunction()
        {
            SendParameterReset();
            _8400_System_On = "84000001";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
            Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;
            _8400_System_On = "84000000";
            Tx_data[RegisterSequencyCounter] = int.Parse(_8400_System_On, styleHex); RegisterSequencyCounter++;

            writeSendFlag = true;

        }

        private void Param_ScanlineSelectViewFunction(int xScanlineNumber)
        {
            int ViewScanLineData = 0;
            if(CH1_DataArray.Length != 0)
            {
                for (int y = 0; y < CH1_Rx_data; y++)
                {
                    ViewScanLineData = CH1_DataArray[xScanlineNumber][y];

                    Console.WriteLine(String.Format("SCANLINE {0} / N of BULK {1} / Data {2}", xScanlineNumber, y, ViewScanLineData));
                }
            }
            
        }

        private void Param_ScanlineTotalViewFunction()
        {
            Console.WriteLine("Finish :: Request Data :{0} / Receive Data : {1}", CH1_Scanline_data, bulkCounter + 1);
            this.Invoke(new Action(delegate ()
            {
                SystemLogBox.AppendText(String.Format("Finish :: Request Data :{0} / Receive Data : {1}", CH1_Scanline_data, bulkCounter + 1) + "\r\n");
            }));
            
        }

        private void Param_ScanlineTestDataSelectViewFunction(int xScanlineNumber)
        {
            int ViewScanLineData = 0;
            if (TEST_DataArray.Length != 0)
            {
                for (int y = 0; y < CH1_Rx_data; y++)
                {
                    ViewScanLineData = TEST_DataArray[xScanlineNumber][y];

                    Console.WriteLine(String.Format("SCANLINE {0} / N of BULK {1} / TEST Data {2}", xScanlineNumber, y, ViewScanLineData));
                }
            }

        }

        private void Param_ScanlineTestDataTotalViewFunction()
        {
            Console.WriteLine("Finish :: Request TEST Data :{0} / Receive TEST Data : {1}", CH1_Scanline_data, frameCounter);
            this.Invoke(new Action(delegate ()
            {
                SystemLogBox.AppendText(String.Format("Finish :: Request TEST Data :{0} / Receive TEST Data : {1}", CH1_Scanline_data, frameCounter) + "\r\n");
            }));


        }
    }
}
