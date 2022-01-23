using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._02Lesson
{
    class BankAccount3 : BankAccount2
    {
        //private int _number;
        //private decimal _balance;
        //private TypeAccount _type;

        //private static int _lastNumber = 0;

        public BankAccount3() : this(0, TypeAccount.Не_определен) { }
        public BankAccount3(decimal balance) : this(balance, TypeAccount.Не_определен) { }
        public BankAccount3(TypeAccount type) : this(0, type) { }
        public BankAccount3(decimal balance, TypeAccount type)
        {
            SetNumber();
            this._balance = balance;
            this._type = type;
        }

    }
    class task03
    {
        public task03()
        {

            Console.WriteLine("Задание №3");
            BankAccount3 bank3 = new();
            BankAccount3 bank33 = new(5000);
            BankAccount3 bank333 = new(TypeAccount.Дебетовый);
            BankAccount3 bank3333 = new(7600, TypeAccount.Кредитовый);
            Console.WriteLine("Конструктор по-умолчанию");
            bank3.GetInfo();
            Console.WriteLine("ctor с 1 аргументом decimal");
            bank33.GetInfo();
            Console.WriteLine("ctor с 1 аргументом TypeAccount");
            bank333.GetInfo();
            Console.WriteLine("ctor с 2 аргументами: decimal и TypeAccount");
            bank3333.GetInfo();
            Console.WriteLine('\n');
        }
    }
}
