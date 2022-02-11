using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lessons._07Lesson
{
    /// <summary>
    /// Определить интерфейс IСoder, который полагает методы поддержки шифрования строк. 
    /// В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования 
    /// и дешифрования строк. Создать класс ACoder, реализующий интерфейс ICoder. Класс шифрует 
    /// строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. (В результате 
    /// такого сдвига буква А становится буквой Б). Создать класс BCoder, реализующий интерфейс ICoder. 
    /// Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву 
    /// того же регистра, расположенную в алфавите на i-й позиции с конца алфавита. (Например, буква 
    /// В заменяется на букву Э. Написать программу, демонстрирующую функционирование классов).
    /// </summary>
    class task01
    {
        public task01()
        {
            a1 = new ACoder();
            b1 = new BCoder();
            ControlMethod();

        }
        ACoder a1;
        BCoder b1;
        public void ControlMethod()
        {
            AEncrypt();
            Thread.Sleep(1000);
            BEncrypt();
        }

        public bool IsRun { get; private set; } = true;

        public void AEncrypt()
        {

            Console.Clear();
            Console.WriteLine("Class A\n" + new string('-', 48));
            Console.Write("Введите строку для шифрования: ");
            string plain = Console.ReadLine();
            string aa1 = a1.Encode(plain);
            Console.WriteLine("Шифрованная строка: {0}", aa1 + '\n');
            Console.WriteLine("Передаем зашифрованную строку для дешифрования ");

            Console.WriteLine("Дешифрованная строка: {0}", a1.Decode(aa1));
            Console.WriteLine(new string('-', 48));
            //IsRun = false;
        }

        public void BEncrypt()
        {
            Console.Clear();
            Console.WriteLine("Class B\n" + new string('-', 48));
            Console.Write("Введите строку для шифрования: ");
            var plain2 = Console.ReadLine();
            Console.WriteLine("Шифрованная строка: {0}", b1.Encode(plain2) + '\n');
            Console.Write("Введите строку для дешифрования: ");
            string coded2 = Console.ReadLine();
            Console.WriteLine("Дешифрованная строка: {0}", b1.Decode(coded2));
            //IsRun = false;
        }
    }
}
