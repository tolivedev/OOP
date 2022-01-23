using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._02Lesson
{
    public enum TypeAccount
    {
        Дебетовый = 1,
        Кредитовый = 2,
        Инвестиционный = 3,
        Не_определен = 0
    }
    public class BankAccount
    {
        private int _number;
        private decimal _balance;
        private TypeAccount _type;

        public void SetNumber(int value)
        {
            _number = value;
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
            Console.WriteLine("Номер банковского счёта: " + _number);
            Console.WriteLine("Баланс банковского счёта: " + _balance);
            Console.WriteLine("Тип банковского счёта: " + _type);
            Console.WriteLine();
        }
    }
    public class task01
    {
        public task01()
        {
            //Задание №1
            Console.WriteLine("Задание №1");
            BankAccount bank = new();
            bank.SetNumber(333);
            bank.SetBalance(2000);
            bank.SetType(TypeAccount.Дебетовый);
            bank.GetInfo();
            Console.WriteLine('\n');

            Console.ReadKey();
        }
    }
}
