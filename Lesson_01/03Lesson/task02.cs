using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._03Lesson
{

    class task02
    {
        public task02()
        {
            Console.WriteLine("Задание №2");
            Console.WriteLine();
            string exampleShort = "123456789";
            char[] temp = new char[5000];
            Random random = new Random();
            for (int i = 0; i < 5000; i++)
            {
                temp[i] += (char)random.Next(0, 127);
            }
            string exampleLong = new string(temp);
            Console.WriteLine("Проверяем на короткой строке корректности работы алгоритмов");
            Console.WriteLine("Исходная строка: " + exampleShort + '\n');
            Console.WriteLine("Переворот через StringBuilder (или просто string): " + ReverseString(exampleShort));
            Console.WriteLine("Переворот через массив символов: " + ReverseStringFast(exampleShort) + '\n');
            Console.WriteLine("Оба варианта переворачивают корректно. Теперь замеряем производительность на короткой и длинной строке (5000 символов)" + '\n');

            Stopwatch timer = new Stopwatch();
            timer.Start();
            ReverseString(exampleShort);
            timer.Stop();
            Console.WriteLine($"Короткая строка через StringBuilder:     {timer.Elapsed} ");
            timer.Restart();
            ReverseStringFast(exampleShort);
            timer.Stop();
            Console.WriteLine($"Короткая строка через массив символов:   {timer.Elapsed} " + '\n');
            timer.Restart();
            ReverseString(exampleLong);
            timer.Stop();
            Console.WriteLine($"Длинная строка через StringBuilder:      {timer.Elapsed} ");
            timer.Restart();
            ReverseStringFast(exampleLong);
            timer.Stop();
            Console.WriteLine($"Длинная строка через массив символов:    {timer.Elapsed} " + '\n');
            Console.WriteLine("Как видим даже на больших строках (для которых предназначен StringBuilder) гораздо быстрее работает алгоритм через массив символов");
        }

        static string ReverseString(string source)
        {
            StringBuilder temp = new StringBuilder(source.Length);
            for (int i = source.Length - 1; i >= 0; i--)
            {
                temp.Append(source[i]);
            }
            return temp.ToString();
        }
        static string ReverseStringFast(string source)
        {
            char[] array = source.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }

}


