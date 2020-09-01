﻿using CyUSB;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        int bulkCounter = 0;
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


                    for (int i = 0; i < XFERSIZE; i += 4)
                    {
                        lastScanlineFinder = (inData[i + 3] << 8) + (inData[i + 2]);
                        //int scanRealData = ((inData[i + 1] & 0x0F) << 8) + (inData[i + 0]);
                        //Console.WriteLine(scanRealData);
                    }

                    for (int i = 0; i < XFERSIZE; i++)
                    {
                        bulkByteSaver[bulkCounter][i] = inData[i];
                        //Console.WriteLine("{0} / {1}", bulkCounter, i);
                    }

                    if (bulkCounter == (CH1_Scanline_data - 1))
                    {
                        Param_ScanlineTotalViewFunction();
                        setSaveDataFlag = false;
                        Console.WriteLine("setSaveDataFlag {0}", setSaveDataFlag);
                        convertDataFlag = true;
                    }

                    if (convertDataFlag)
                    {
                        convertDataFlag = false;
                        this.Invoke(new Action(delegate ()
                        {
                            GraphicConvertByteToInt();
                        }));
                    }


                    //*/ Bulk Counter
                    //Console.WriteLine("bulkCounter {0}", bulkCounter);
                    bulkCounter++;

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

            CH1_DataArray = new int[CH1_Scanline_data][];
            for (int i = 0; i < CH1_DataArray.GetLength(0); i++)
            {
                CH1_DataArray[i] = new int[CH1_Rx_data];
            }
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

            width_ImagingBox = ImagingBox.Width;
            height_ImagingBox = ImagingBox.Height;
            bitmapImaging = new Bitmap(512, 1331);
            bitmapRenew = bitmapImaging as Bitmap;
            ImagingBox.Image = bitmapRenew;
        }



    }
}
