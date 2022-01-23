using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._02Lesson
{
    class BankAccount2
    {
        internal int _number;
        internal decimal _balance;
        internal TypeAccount _type;

        private static int _lastNumber = 0;
        public void SetNumber()
        {
            _number = _lastNumber + 1;
            _lastNumber = _number;
        }
        public int GetNumber()
        {
            return _number;
        }
        public void SetBalance(decimal value)
        {
            _balance = value;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void SetType(TypeAccount value)
        {
            _type = value;
        }
        public TypeAccount GetTypeAccount()
        {
            return _type;
        }
        public void GetInfo()
        {
            Console.WriteLine("Номер банковского счёта: " + GetNumber());
            Console.WriteLine("Баланс банковского счёта: " + GetBalance());
            Console.WriteLine("Тип банковского счёта: " + GetTypeAccount());
            Console.WriteLine();
        }
    }
    class task02
    {
        public task02()
        {
            Console.WriteLine("Задание №2");
            BankAccount2 bank2 = new BankAccount2();
            BankAccount2 bank22 = new BankAccount2();
            bank2.SetNumber();
            bank2.SetBalance(2000);
            bank22.SetNumber();
            bank22.SetBalance(3000);
            bank2.SetType(TypeAccount.Дебетовый);
            bank2.GetInfo();
            bank22.GetInfo();
            Console.WriteLine('\n');
        }
    }

}

