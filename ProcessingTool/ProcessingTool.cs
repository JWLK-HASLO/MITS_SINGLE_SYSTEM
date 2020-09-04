using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        int ConvolveHPFLength;
        int ConvolveLPF_QD_Length;
        int ConvolveLPF_DECI_Length;
        double[] getData;
        double[] ResultData;
        double[] Inphase;
        double[] Quadrature;
        double[] Inphase_Final;
        double[] Quadrature_Final;
        double[] Envelope;
        double[] ScanlineConvertData;
        double[][] ConvertSaveArray;


        double[] cos;
        double[] sin;

        public bool SignalProcessing(int[][] dataArray)
        {

            ConvolveHPFLength = CH1_CM_Length + HPF_Length - 1;
            ConvolveLPF_QD_Length = CH1_CM_Length + LPF_QD_Length - 1;
            ConvolveLPF_DECI_Length = CH1_CM_Length + LPF_DECI_Length - 1;

            for (int x = 0; x < CH1_Scanline_data; x++)
            {
                for (int y = 0; y < CH1_CM_Length; y++)
                {
                    //*/ Real Data
                    getData[y] = Convert.ToDouble(dataArray[x][y] - 2048);
                    //Console.WriteLine(String.Format("{0}", getData[y]));

                    //*/

                }
                ResultData = Convolve(getData, HPF_Data, CH1_CM_Length, HPF_Length, ConvolveHPFLength);
                for (int i = 0; i < CH1_CM_Length; i++)
                {
                    cos[i] = 2 * Math.Cos(radian * i) * ResultData[i];
                    sin[i] = -2 * Math.Sin(radian * i) * ResultData[i];
                }
                Inphase = Convolve(cos, LPF_QD_Data, CH1_CM_Length, LPF_QD_Length, ConvolveLPF_QD_Length);
                Quadrature = Convolve(sin, LPF_QD_Data, CH1_CM_Length, LPF_QD_Length, ConvolveLPF_QD_Length);

                if (CH1_CM_Divider == 1)
                {
                    Inphase_Final = Inphase;
                    Quadrature_Final = Quadrature;
                }
                else
                {
                    Inphase_Final = Convolve(Inphase, LPF_DECI_Data, CH1_CM_Length, LPF_DECI_Length, ConvolveLPF_DECI_Length);
                    Quadrature_Final = Convolve(Quadrature, LPF_DECI_Data, CH1_CM_Length, LPF_DECI_Length, ConvolveLPF_DECI_Length);
                }

                for (int i = 0; i < CH1_CM_Length; i += CH1_CM_Divider)
                {
                    Envelope[i / CH1_CM_Divider] = Math.Sqrt(Inphase_Final[i] * Inphase_Final[i] + Quadrature_Final[i] * Quadrature_Final[i]);
                    //Console.WriteLine(String.Format("{0}", Envelope[i / CH1_CM_Divider]));
                }
                for (int i = 0; i < CH1_CM_Length / CH1_CM_Divider; i++)
                {
                    if (Envelope[i] >= xMin && Envelope[i] <= xMax)
                    {
                        ScanlineConvertData[i] = yMax / LogRange * Math.Log10(Envelope[i] / xMin);

                    }
                }

                Array.Copy(ScanlineConvertData, 0, ConvertSaveArray[x], 0, CH1_CM_Length / CH1_CM_Divider);
            }
            return true;


        }
    }
}
