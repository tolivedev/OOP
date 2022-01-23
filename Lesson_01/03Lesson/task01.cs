using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons._02Lesson;

namespace Lessons._03Lesson
{
    class BankAccount 
    {
        public TypeAccount Type { get; set; }

        int Number;
        decimal Balance;

        public BankAccount() : this(0, TypeAccount.Не_определен, 0) { }
        public BankAccount(decimal balance) : this(balance, TypeAccount.Не_определен, 0) { }
        public BankAccount(TypeAccount type) : this(0, type, 0) { }
        public BankAccount(int number) : this(0, TypeAccount.Не_определен, number) { }
        public BankAccount(decimal balance, TypeAccount type) : this(balance, type, 0) { }
        public BankAccount(decimal balance, TypeAccount type, int number)
        {
            Number = number;
            Balance = balance;
            Type = type;
        }

        public void SetNumber(int value)
        {
            Number = value;
        }
        public int GetNumber()
        {
            return Number;
        }
        public void SetBalance(decimal value)
        {
            Balance = value;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public void SetType(TypeAccount value)
        {
            Type = value;
        }
        public TypeAccount GetTypeAccount()
        {
            return Type;
        }
        public void GetInfo()
        {
            Console.WriteLine("Номер банковского счёта: " + Number);
            Console.WriteLine("Баланс банковского счёта: " + Balance);
            Console.WriteLine("Тип банковского счёта: " + Type);
            Console.WriteLine();
        }

        public void Transaction(BankAccount sender, decimal sum)
        {
            if (sender.Balance >= sum)
            {
                sender.Balance -= sum;
                //Balance += sum;
                Console.WriteLine($"Перевод средств произведен успешно. На Ваш счёт поступило {sum} у.е. Текущий баланс: {sender.Balance} у.е.");
            }
            else
            {
                Console.WriteLine("Ошибка! Недостаточно средств на счёте отправителя.");
            }

        }

    }

    /*
        1. В класс банковский счет, созданный в упражнениях, добавить метод, 
        который переводит деньги с одного счета на другой. У метода два параметра: 
        ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
        2. Реализовать метод, который в качестве входного параметра принимает строку string, 
        возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.
    */
    class task01
    {

        public task01()
        {
            Console.WriteLine("Задание №1");
            BankAccount bank = new();
            bank.SetNumber(333);
            bank.SetBalance(2000);
            bank.SetType(TypeAccount.Дебетовый);
            
            Console.WriteLine();
            bank.Transaction(bank, 200);
            bank.GetInfo();
            Console.WriteLine("Инфо о счёте отправителя");
            Console.WriteLine();
        }
    }
}
