using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.4	В двухмерном массиве вещественных чисел поменять местами строки и столбцы с одинаковыми номерами.
// 2.4	Составить программу, которая будет вводить строку в переменную String. Определить, сколько раз в 
// строке встречается заданное слово.
// 3.4	Задан текст. После каждой буквы «о» вставить сочетание «Oк».

namespace Лабораторная1.В4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1.Matrix();
            Task2.Strings();
            Task3.RegularExpressions();
        }
    }
}
