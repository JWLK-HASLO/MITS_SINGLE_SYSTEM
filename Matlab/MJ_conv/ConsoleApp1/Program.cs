using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        


        static double[] Convolve(double[] u, double[] v, int data_length, int Impulse_response_length, int conv_length)
        {
            var w = new double[conv_length]; // an array to store the results

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

        static void Main(string[] args)
        {
            int Deci_factor = 1;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            string[] data = File.ReadAllLines(@"C:\Users\parks\Desktop\MITS_0928\MITS_US_HOST\Matlab\data1.txt");  /// original data load.
            double[] u = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                u[i] = Convert.ToDouble(data[i])-2048;
            }
            int data_length = u.Length;

            // Load HPF coeffcients
            string[] tmp = File.ReadAllLines("HPF.txt");
            double[] HPF = new double[tmp.Length];

            for (int i = 0; i < HPF.Length; i++)
            {
                HPF[i] = Convert.ToDouble(tmp[i]);
            }
            int HPF_length = HPF.Length;

            // Load LPF coeffcients for quadrature demodulation
            tmp = File.ReadAllLines("LPF_8.txt");
            double[] LPF_QD = new double[tmp.Length];

            for (int i = 0; i < LPF_QD.Length; i++)
            {
                LPF_QD[i] = Convert.ToDouble(tmp[i]);
            }
            int LPF_QD_length = LPF_QD.Length;

            // Load LPF coeffcients for decimation
            tmp = File.ReadAllLines("LPF_DECI2.txt");
            double[] LPF_DECI = new double[tmp.Length];

            for (int i = 0; i < LPF_DECI.Length; i++)
            {
                LPF_DECI[i] = Convert.ToDouble(tmp[i]);
            }
            int LPF_DECI_length = LPF_DECI.Length;

            // HPF - DC rejection
            int conv_length = data_length + HPF_length - 1;
            double[] D_hpf = Convolve(u, HPF, data_length, HPF_length, conv_length);


            // Qudrature demodulation - I/Q generation
            int fc = 20000000;
            int fs = 100000000;
            const double pi = 3.141592;
            double radian = (2 * pi * fc) / fs;
            double[] cos = new double[data.Length];
            double[] sin = new double[data.Length];

            sw.Start();
            for (int i = 0; i < data_length; i++)
            {
                cos[i] = 2*Math.Cos(radian * i) * D_hpf[i];
                sin[i] = -2*Math.Sin(radian * i) * D_hpf[i];
            }

            conv_length = data_length + LPF_QD_length - 1;
            double[] Inphase = Convolve(cos, LPF_QD, data_length, LPF_QD_length, conv_length);
            double[] Quadrature = Convolve(sin, LPF_QD, data_length, LPF_QD_length, conv_length);
            double[] Inphase_1 = new double[data.Length / Deci_factor];
            double[] Quadrature_1 = new double[data.Length / Deci_factor];

            // Decimation and Envelope detection
            if (Deci_factor == 1)
            {
                Inphase_1 = Inphase;
                Quadrature_1 = Quadrature;
            }
            else
            {
                conv_length = data_length + LPF_DECI_length - 1;
                Inphase_1 = Convolve(Inphase, LPF_DECI, data_length, LPF_DECI_length, conv_length);
                Quadrature_1 = Convolve(Quadrature, LPF_DECI, data_length, LPF_DECI_length, conv_length);
            }
                
            double[] Envelope = new double[data.Length / Deci_factor];
 
            for (int i = 0; i < data_length; i+=Deci_factor)
            {
                Envelope[i / Deci_factor] = Math.Sqrt(Inphase_1[i]* Inphase_1[i] + Quadrature_1[i] * Quadrature_1[i]);
            }
            int Data_DECI_length = Envelope.Length;

            // Log compression
            int Ymax = 2 ^ 8 - 1;
            int Dynamic_range = 50;     // input parameter
            int Xmax = 2 ^ 12;
            double Xmin = 10 ^ (-Dynamic_range / 20) * Xmax;
            double Log_range = Math.Log10(Xmax / Xmin);

            double[] Logout = new double[Data_DECI_length];
            for (int i = 0; i < Data_DECI_length; i++)
            {
                if (Envelope[i] >= Xmin)
                {
                    Logout[i] = Ymax / Log_range * Math.Log10(Envelope[i] / Xmin);
                }
            }
            sw.Stop();
            

            Console.WriteLine("Time : " + sw.Elapsed.ToString() + "mS");
            foreach (double element in Envelope)
                Console.Write(element + "\n");
            Console.ReadKey();
        }


    }
}