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
        Color rgb;

        int rgbIndex;
        int ScanlineData;
        int ScanRealData;

        Thread graphicDrawThread;

        private void GraphicConvertInit()
        {
            rgb = Color.FromArgb(0, 0, 0);
            rgbIndex = 0;
            ScanlineData = 0;
            ScanRealData = 0;
        }
        private void GraphicConvertByteToInt()
        {
            for (int x = 0; x < CH1_Scanline_data; x++)
            {
                for (int y = 0, bulk = 0; y < CH1_Rx_data; y++, bulk += 4)
                {
                    ScanlineData = (bulkByteSaver[x][bulk + 3] << 8) + (bulkByteSaver[x][bulk + 2]);
                    ScanRealData = ((bulkByteSaver[x][bulk + 1] & 0x0F) << 8) + bulkByteSaver[x][bulk + 0];

                    Console.WriteLine(String.Format("SCANLINE {0} / N of BULK {1}", ScanlineData, ScanRealData));

                    CH1_DataArray[x][y] = ScanRealData;
                }
            }
            //Console.WriteLine("Data Convert Complete");
            //SignalProcessing(CH1_DataArray);
            //Draw Flag
            if (!drawResultFlag)
            {
                drawResultFlag = true;

            }
        }

        /* TEST DATA INIT */
        delegate void TimerEventFiredDelegate();
        System.Timers.Timer timer = null;
        System.Timers.Timer timerReadData = null;

        System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
        TimeSpan timSpan = new TimeSpan(0, 0, 0, 0);

        int frameCounter = 0;
        int raiseCounter = 0;

        int[][] TEST_DataArray;

        /* #3-1 Record Setting : Timer Initialization */
        public void timer_initialize()
        {
            textBox_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", 0, 0, 0);
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        }

        /* #3-2 Record Setting : Timer Elapsed Event And Worker Setting  */
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new TimerEventFiredDelegate(Timer_Worker));
        }

        private void Timer_Worker()
        {
            /* Time Span Log */
            timSpan = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
                        timSpan.Hours, timSpan.Minutes, timSpan.Seconds,
                        timSpan.Milliseconds / 10);
            textBox_timer.Text = elapsedTime;

            //*/ Data - Array Example Load
            for (int x = 0; x < CH1_Scanline_data; x++, raiseCounter++)
            {
                for (int y = 0; y < height_ImagingBox; y++)
                {
                    TEST_DataArray[x][y] = (y + raiseCounter) % 4096;
                }
            }
            SignalProcessing(TEST_DataArray);

            //*/
            if (!drawResultFlag)
            {
                drawResultFlag = true;

            }

            //*/ Data - Array Frame Counter 
            frameCounter++;
            //*/

            //*/ Data - Array Example Counter 
            raiseCounter = (CH1_Rx_data / CH1_Scanline_data) * frameCounter;
            //*/
        }


        public void DrawThread()
        {
            while (true)
            {
                Thread.Sleep(33);
                if (drawResultFlag)
                {
                    drawResultFlag = false;
                    this.Invoke(new Action(delegate ()
                    {
                        for (int x = 0; x < CH1_Scanline_data; x++)
                        {
                            for (int y = 0; y < ConvertSaveArray[x].Length; y++)
                            {
                                /*/ TERST Data
                                rgbIndex = TEST_DataArray[x][y];
                                rgb = colorStepArrayBackGround[rgbIndex];
                                //*/

                                //*/ Real Data
                                rgbIndex = (int)ConvertSaveArray[x][y];
                                rgb = Color.FromArgb(rgbIndex, rgbIndex, rgbIndex);
                                //*/

                                bitmapRenew.SetPixel(x, y, rgb);
                            }
                        }
                        ImagingBox.Image = bitmapRenew;
                        ImagingBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        ImagingBox.Update();

                    }
                    ));

                }
            }
        }
    }
}
