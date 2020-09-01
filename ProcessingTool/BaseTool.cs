using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITS_SINGLE_SYSTEM
{
    public partial class MITS_SYSTEM
    {
        //*/ Export Data Value
        string[] HPF_Load;
        int HPF_Length;
        double[] HPF_Data;

        string[] LPF_QD_Load;
        int LPF_QD_Length;
        double[] LPF_QD_Data;

        string[] LPF_DECI_Load;
        int LPF_DECI_Length;
        double[] LPF_DECI_Data;
        //*/

        //*/ Static Value
        static int fc = 8000000;   //  8,000,000
        static int fs = 100000000; //100,000,000
        const double pi = 3.141592;
        static double radian = (2 * pi * fc) / fs;
        //*/

        //*/ Min Max Value
        double xMin;
        double xMax = Math.Pow(2.0, 12.0) - 1;
        static double yMax = Math.Pow(2.0, 8.0) - 1.0;
        double LogRange;
        //*/


        private void ProcessingBaseToolInit()
        {

            //*/ HPF Data
            HPF_Load = File.ReadAllLines("HPF.txt");
            HPF_Length = HPF_Load.Length;
            HPF_Data = new double[HPF_Length];
            for (int i = 0; i < HPF_Length; i++)
            {
                HPF_Data[i] = Convert.ToDouble(HPF_Load[i]);
                //Console.WriteLine(HPF_Data[i]);
            }
            //*/

            //*/ LPF QD Data
            LPF_QD_Load = File.ReadAllLines("LPF_18.txt");
            LPF_QD_Length = LPF_QD_Load.Length;
            LPF_QD_Data = new double[LPF_QD_Length];
            for (int i = 0; i < LPF_QD_Length; i++)
            {
                LPF_QD_Data[i] = Convert.ToDouble(LPF_QD_Load[i]);
                //Console.WriteLine(LPF_QD_Data[i]);
            }
            //*/


            //*/ LPF QD Data
            LPF_DECI_Load = File.ReadAllLines("LPF_DECI2.txt");
            LPF_DECI_Length = LPF_DECI_Load.Length;
            LPF_DECI_Data = new double[LPF_DECI_Length];
            for (int i = 0; i < LPF_DECI_Length; i++)
            {
                LPF_DECI_Data[i] = Convert.ToDouble(LPF_DECI_Load[i]);
                //Console.WriteLine(LPF_DECI_Data[i]);
            }
            //*/



        }


        //Convolve(getData, HPF_Data, CH1_CM_Length, HPF_Length, ConvolveHPFLength);
        double[] Convolve(double[] u, double[] v, int data_length, int Impulse_response_length, int conv_length)
        {
            double[] w = new double[conv_length]; // an array to store the results : 1331 * n + HPF_Length(65) -1

            for (int i = 0; i < conv_length; i++) // convoultion loops
            {
                for (int j = 0; j < Impulse_response_length; j++)
                {
                    if (i - j >= 0 && i - j < data_length)
                    {
                        w[i] += u[i - j] * v[j];
                    }
                }
            }

            var convn = new double[data_length];

            Array.Copy(w, (Impulse_response_length - 1) / 2, convn, 0, data_length);

            return convn;
        }


    }
}
