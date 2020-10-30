using CyUSB;
using Microsoft.SqlServer.Server;
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
        bool readResultFlag = false;    // READ (*IN)  data transfer Trigger
        bool writeSendFlag = false;     // WRITE (*Out) data transfer Trigger
        bool setSaveDataFlag = false;   // Data Read Timing Matching (Init Stat Button) Trigger
        bool convertDataFlag = false;   // Convert Byte 1D Data to Int 2D Data Trigger
        bool drawResultFlag = false;    // DRAW (*IMG) data transfer Trigger

        int lastScanlineFinder = 0;
        int scanRealData = 0;
        int dataCounter = 0;
        int bulkCounter = 0;
        int bulkCounter_loopMode = 0;
        byte[][] bulkByteSaver;

        public void ReadThread()
        {
            while (true)
            {
                Thread.Sleep(1);

                int xferlength = xferLen_Read;
                readResultFlag = inEndpoint.XferData(ref inData, ref xferlength);

                //Buffer.BlockCopy 형태로 리뉴얼 시켜서 테스트
                //Buffer.BlockCopy(sources, 0, target, 0, sources.Length);
                //bulkCounter 이용해서 source => target 버퍼로 

                if (readResultFlag && setSaveDataFlag)
                {
                    //for (int i = 0; i < XFERSIZE; i += 4)
                    //{
                    //    lastScanlineFinder = (inData[i + 3] << 8) + (inData[i + 2]);
                    //    //int scanRealData = ((inData[i + 1] & 0x0F) << 8) + (inData[i + 0]);
                    //    //Console.WriteLine(lastScanlineFinder);
                    //}

                    //if (lastScanlineFinder == (CH1_Scanline_data - 1) && dataCounter == 16384)
                    //{
                    //    Param_ScanlineTotalViewFunction();
                    //    convertDataFlag = true;
                    //}

                    if (!linear_loopModeState)
                    {
                        if (bulkCounter < CH1_Scanline_data)
                        {
                            for (int i = 0; i < XFERSIZE; i++)
                            {
                                bulkByteSaver[bulkCounter][i] = inData[i];
                                //Console.WriteLine("{0} / {1}", bulkCounter, i);
                                //dataCounter++;
                            }
                            //Console.WriteLine("Get Data: {0}", bulkCounter);
                        }
                        if (bulkCounter == (CH1_Scanline_data - 1))
                        {
                            Param_ScanlineTotalViewFunction();
                            //Console.WriteLine("ConvertDataFlag Data: {0}", bulkCounter);
                            convertDataFlag = true;
                        }
                        bulkCounter++;
                    }
                    else
                    {
                        //for (int i = 0; i < XFERSIZE; i += 4)
                        //{
                        //    lastScanlineFinder = (inData[i + 3] << 8) + (inData[i + 2]);
                        //    scanRealData = ((inData[i + 1] & 0x0F) << 8) + (inData[i + 0]);
                        //    //Console.WriteLine("BulkCounter : {0} / Scanline : {1} / RealData : {2}", bulkCounter, lastScanlineFinder, scanRealData);
                        //}
                        for (int i = 0; i < XFERSIZE; i++)
                        {
                            bulkByteSaver[bulkCounter][i] = inData[i];
                            //Console.WriteLine("{0} / {1}", bulkCounter, i);
                            //dataCounter++;
                        }

                        if (bulkCounter == (CH1_Scanline_data - 1))
                        {
                            Param_ScanlineTotalViewFunction();
                            //Console.WriteLine("ConvertDataFlag Data: {0}", bulkCounter);
                            convertDataFlag = true;
                        }

                        bulkCounter++;


                    }


                    if (convertDataFlag)
                    {
                        convertDataFlag = false;
                        setSaveDataFlag = false;

                        //Set Timer Setting
                        motor_timer.Stop();
                        //Set StopWatch
                        motor_stopWatch.Stop();

                        this.Invoke(new Action(delegate ()
                        {
                            GraphicConvertByteToInt();
                        }));
                    }


                    //*/ Bulk Counter
                    //Console.WriteLine("bulkCounter {0}", bulkCounter);

                    //if (dataCounter == 16384)
                    //{
                    //    dataCounter = 0;
                    //}

                }

            }
            
        }

        public void WriteThread()
        {
            while (true)
            {
                Thread.Sleep(100);
                if (writeSendFlag == true)
                {
                    writeSendFlag = false;

                    bool bResult = true;
                    int j = 0;
                    int counter = 0;
                    for (int i = 0; i < XFERSIZE; i += 4, counter++)
                    {
                        outData[i + 3] = (byte)(Tx_data[j] >> 24);
                        outData[i + 2] = (byte)(Tx_data[j] >> 16);
                        outData[i + 1] = (byte)(Tx_data[j] >> 8);
                        outData[i + 0] = (byte)Tx_data[j];
                        //Console.WriteLine("TX_DATA [{0}] : {1}{2}{3}{4} ", counter, outData[i + 3].ToString("X"), outData[i + 2].ToString("X"), outData[i + 1].ToString("X"), outData[i + 0].ToString("X"));
                        j++;

                    }
                    int xferlengths = xferLen_Write;
                    bResult = outEndpoint.XferData(ref outData, ref xferlengths);
                    if (bResult == false)
                        outEndpoint.Reset();


                    writeSendFlag = false;  // Close Data Write
                }
            }
        }


        public void SendParameterReset()
        {
            RegisterSequencyCounter = 0;
            Tx_data = new int[4096];       // Tx Data Array Reset;
            bulkCounter = 0;

            bulkByteSaver = new byte[CH1_Scanline_data][];
            for (int i = 0; i < bulkByteSaver.GetLength(0); i++)
            {
                bulkByteSaver[i] = new byte[CH1_Rx_data * 4];
            }

            ConvertSaveArray = new double[CH1_Scanline_data][];
            for (int i = 0; i < ConvertSaveArray.GetLength(0); i++)
            {
                ConvertSaveArray[i] = new double[CH1_CM_Length / CH1_CM_Divider];
            }

            CH1_DataArray = new int[CH1_Scanline_data][];
            for (int i = 0; i < CH1_DataArray.GetLength(0); i++)
            {
                CH1_DataArray[i] = new int[CH1_Rx_data];
            }
            ScanlineConvertData = new double[CH2_CM_Length / CH2_CM_Divider];


        }


        public void SendParameterTestReset()
        {
            frameCounter = 0;
            raiseCounter = 0;
            TEST_DataArray = new int[CH1_Scanline_data][];

            for (int i = 0; i < TEST_DataArray.GetLength(0); i++)
            {
                TEST_DataArray[i] = new int[CH1_Rx_data];
            }
        }

        public void GraphicImagingDataReset()
        {
            rgbIndex = 0;
            rgb = Color.FromArgb(0, 0, 0);
            bitmapImaging = new Bitmap(globalWidth, globalHeight);
            bitmapRenew = bitmapImaging as Bitmap;
            //ImagingBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagingBox.Image = bitmapRenew;

            // A-Mode
            setAmodeChart();
        }



    }
}
