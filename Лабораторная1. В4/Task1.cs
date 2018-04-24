using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная1.В4
{
    public static class Task1
    {
        public static void Matrix()
        {
            int n = 5;
            double[,] Mass = new double[n, n];
            Random rnd = new Random(0);
            Console.WriteLine("1.4) В двухмерном массиве вещественных чисел поменять местами строки и столбцы с одинаковыми номерами:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Mass[i, j] = rnd.NextDouble();
            OutputMatrix(Mass, n);
            Swap(Mass, n);
            Console.WriteLine("\nРезультат:");
            OutputMatrix(Mass, n);
        }

        public static void Swap(double[,] Mass, int n)
        {
            double a;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    a = Mass[i, j];
                    Mass[i, j] = Mass[j, i];
                    Mass[j, i] = a;
                }
            }
        }

        public static void OutputMatrix(double[,] Mass,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0:f6}\t", Mass[i, j]);
                Console.WriteLine();
            }
        }
    }
}
