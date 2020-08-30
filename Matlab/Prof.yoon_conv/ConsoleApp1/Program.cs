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

        static double[] Convolve(double[] u, double[] v, int data_length, int Impulse_response_length, int Impulse_response_length_half)
        {
            var data = new double[data_length + Impulse_response_length-1];
            Array.Copy(u, 0, data, Impulse_response_length_half, data_length);

            var w = new double[data_length];
            for (int i=0; i < data_length; i++)
            {
                for (int j=0; j < Impulse_response_length; j++)
                {
                    w[i] += data[i + j] * v[Impulse_response_length - 1 - j];
                }
            }
            return w;
        }
        

 /*       static double[] Convolve(double[] u, double[] v, int data_length, int Impulse_response_length, int conv_length)
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
            
            
        }
*/
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            string[] data = File.ReadAllLines(@"C:\Users\smj\Desktop\2018_09_13_Host\Matlab\data1.txt");
            double[] u = new double[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                u[i] = Convert.ToDouble(data[i]);
            }
            int data_length = u.Length;

            string[] Impulse_response = File.ReadAllLines(@"C:\Users\smj\Desktop\2018_09_13_Host\Matlab\Impulse_response.txt");
            double[] v = new double[Impulse_response.Length];

            for(int i = 0; i < Impulse_response.Length; i++)
            {
                v[i] = Convert.ToDouble(Impulse_response[i]);
            }
            int Impulse_response_length = v.Length;

            int Impulse_response_length_half = Impulse_response_length/2;
            
            sw.Start();
            double[] convn = Convolve(u, v, data_length, Impulse_response_length, Impulse_response_length_half);
            sw.Stop();

            // Coe,sin
            int fc = 20000000;
            int fs = 100000000;
            const double pi = 3.141592;
            double radian = (2 * pi * fc) / fs;
            double[] cos = new double[data.Length];
            double[] sin = new double[data.Length];

            for (int i = 0; i < data_length; i++)
            {
                cos[i] = 2*Math.Cos(radian * i) * convn[i];
                sin[i] = -2*Math.Sin(radian * i) * convn[i];
            }

            double[] inphase = Convolve(cos, v, data_length, Impulse_response_length, Impulse_response_length_half);
            inphase = Convolve(inphase, v, data_length, Impulse_response_length, Impulse_response_length_half);
            double[] quadrature = Convolve(sin, v, data_length, Impulse_response_length, Impulse_response_length_half);
            quadrature = Convolve(quadrature, v, data_length, Impulse_response_length, Impulse_response_length_half);
            


            Console.WriteLine("Time : " + sw.Elapsed.ToString()+"mS");

            Console.Write("convn\n");
            foreach (double element in convn)
                Console.Write(element + "\n");

            Console.ReadKey();
        }

       
    }
}
