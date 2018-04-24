using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная1.В4
{
    public static class Task2
    {
        public static void Strings()
        {
            Console.WriteLine("\n2.4) Составить программу, которая будет вводить строку в переменную String. Определить, сколько раз в строке встречается заданное слово.");
            string s, s1;
            Console.Write("Введите строку: ");
            s = Console.ReadLine();
            Console.Write("Введите слово: ");
            s1 = Console.ReadLine();
            string s2 = GetWord(s, s1);
            Console.WriteLine("Результат: {0}", s2);
        }

        public static string GetWord(string s, string s1)
        {
            string[] ss = s.Split(' ');
            return Convert.ToString(ss.Count(l => l == s1));
        }
    }
}
