using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Лабораторная1.В4
{
    public static class Task3
    {
        public static void RegularExpressions()
        {
            Console.WriteLine("\n3.4) Задан текст. После каждой буквы «о» вставить сочетание «Oк».");
            string text = "Озябшая оса облетела осот, облизала оставшийся остывший обед, отползла от ограды, отыскала отверстие, отогрелась.";
            Console.WriteLine("Первоначальная строка: {0}", text);
            Console.WriteLine("Результат: {0}\n", GetText(text));
        }

        public static string GetText(string text)
        {
            string a = "о";
            string b = "оОк";
            Regex regex = new Regex(a);            
            string result = regex.Replace(text, b);
            return result;
        }
    }
}