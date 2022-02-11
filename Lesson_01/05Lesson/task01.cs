using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._05Lesson
{
    /// <summary>
    /// Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. 
    /// Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, 
    /// <=, >=, +, –, ++, --. Переопределить метод ToString() для вывода дроби. 
    /// Определить операторы преобразования типов между типом дробь,float, int. 
    /// Определить операторы *, /, %.
    /// </summary>
    public class Digits : IComparable<Digits>
    {
        public int numerator { get; set; }
        public int denominator { get; set; }


        public Digits() { }
        public Digits(int num, int den)
        {
            numerator = num;
            denominator = den;
        }

        // override methods
        public override int GetHashCode() => this.ToString().GetHashCode();
        public override bool Equals(object? obj) => obj.ToString() == this.ToString();

        public int CompareTo(Digits? other)
        {
            if ((this.numerator * other.denominator) > (other.numerator * this.denominator) && (this.denominator * other.denominator) == (other.denominator * this.denominator)) return 1;
            if ((this.numerator * other.denominator) < (other.numerator * this.denominator) && (this.denominator * other.denominator) == (other.denominator * this.denominator)) return -1;
            else return 0;
        }

        // переопределем операторы
        public static bool operator ==(Digits d1, Digits d2) => d1.Equals(d2);
        public static bool operator !=(Digits d1, Digits d2) => !d1.Equals(d2);

        public static bool operator >(Digits d1, Digits d2) => d1.CompareTo(d2) > 0;
        public static bool operator <(Digits d1, Digits d2) => d1.CompareTo(d2) < 0;
        public static bool operator <=(Digits d1, Digits d2) => d1.CompareTo(d2) <= 0;
        public static bool operator >=(Digits d1, Digits d2) => d1.CompareTo(d2) >= 0;

        public static Digits operator +(Digits d1, Digits d2) => new Digits(
            ((d1.numerator * d2.denominator) + (d2.numerator * d1.denominator)), d1.denominator * d2.denominator);
        public static Digits operator -(Digits d1, Digits d2) => new Digits(
            ((d1.numerator * d2.denominator) - (d2.numerator * d1.denominator)), d1.denominator * d2.denominator);

        public static Digits operator ++(Digits d1) => new Digits(d1.numerator + 1, d1.denominator + 1);
        public static Digits operator --(Digits d1) => new Digits(d1.numerator - 1, d1.denominator - 1);

        public static Digits operator *(Digits d1, Digits d2) =>
            new Digits(d1.numerator * d2.numerator, d1.denominator * d2.denominator);
        public static Digits operator /(Digits d1, Digits d2) =>
            new Digits(d1.numerator * d2.denominator, d1.denominator * d2.numerator);

        public static explicit operator float(Digits d1)
        {
            return (float)d1.numerator / d1.denominator;
        }

        public override string ToString()
        {
            return $"Дробь: {numerator}/{denominator}";
        }

        public void ControlMethod()
        {
            Console.WriteLine("-> Класс рациональных чисел");
            Console.WriteLine(new string('-', 48));
            Console.Write("Введите чиcлитель дроби 1:");
            int num = Int32.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель дроби 1:");
            int den = Int32.Parse(Console.ReadLine());
            Digits d1 = new Digits(num, den); // первая дробь
            Console.WriteLine(d1.ToString());

            Console.Write("Введите чиcлитель дроби 2:");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель дроби 2:");
            int den2 = Int32.Parse(Console.ReadLine());
            Digits d2 = new Digits(num2, den2); // вторая дробь
            Console.WriteLine(d2.ToString());

            Console.WriteLine(new string('-', 32));
            Console.WriteLine("--------------- Операции с дробями ----------------");

            Console.WriteLine($"{d1.ToString()} == {d2.ToString()} результат: {d1 == d2}");
            Console.WriteLine($"{d1.ToString()} != {d2.ToString()} результат: {d1 != d2}" + '\n');

            Console.WriteLine($"{d1.ToString()} > {d2.ToString()} результат: {d1 > d2}");
            Console.WriteLine($"{d1.ToString()} < {d2.ToString()} результат: {d1 < d2}");
            Console.WriteLine($"{d1.ToString()} >= {d2.ToString()} результат: {d1 >= d2}");
            Console.WriteLine($"{d1.ToString()} <= {d2.ToString()} результат: {d1 <= d2}" + '\n');

            Console.WriteLine($"{d1.ToString()} + {d2.ToString()} результат: {d1 + d2}");
            Console.WriteLine($"{d1.ToString()} - {d2.ToString()} результат: {d1 - d2}");
            Console.WriteLine($"{d1.ToString()} ++ результат: {++d1}");
            Console.WriteLine($"{d1.ToString()} -- результат: {--d1}" + '\n');

            Console.WriteLine($"{d1.ToString()} * на {d2.ToString()} результат: {d1 * d2}");
            Console.WriteLine($"{d1.ToString()} / на {d2.ToString()} результат: {d1 / d2}");
            Console.WriteLine($"{d1.ToString()} % {d2.ToString()} результат: ");

            Console.WriteLine("Преобразование {0} в тип float: {1:G}", d1, (float)d1);

            Console.WriteLine(new string('-', 47));
            Console.WriteLine("Для выхода жми \"Enter\"");
            Console.ReadLine();
        }
    }

    class task01
    {
        // После замечаний во втором проекте, убрал из конструткора логику управления таской.
        public task01()
        {
            new Digits().ControlMethod();
        }

    }
}
