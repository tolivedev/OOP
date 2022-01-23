using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._02Lesson
{
    class BankAccount4
    {
        private static int _lastNumber = 0;

        private int _number;
        private decimal _balance;
        private TypeAccount _type;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value <= _lastNumber)             
                {                                     
                    _number = _lastNumber++;         
                    _lastNumber = _number;           
                }
                else
                {
                    _number = value;
                }
            }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public TypeAccount Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public BankAccount4() : this(0, TypeAccount.Не_определен, 0) { }
        public BankAccount4(decimal balance) : this(balance, TypeAccount.Не_определен, 0) { }
        public BankAccount4(TypeAccount type) : this(0, type, 0) { }
        public BankAccount4(int number) : this(0, TypeAccount.Не_определен, number) { }
        public BankAccount4(decimal balance, TypeAccount type) : this(balance, type, 0) { }
        public BankAccount4(decimal balance, TypeAccount type, int number)
        {
            Number = number;
            Balance = balance;
            Type = type;
        }

        public void GetInfo()
        {
            Console.WriteLine("Номер банковского счёта: {0}" + 
                "\nБаланс банковского счёта: {1}" + 
                "\nТип банковского счёта: {2}" + 
                '\n', Number, Balance, Type);
        }
    }

    class task04
    {
        public task04()
        {
            Console.WriteLine("Задание №4");
            BankAccount4 bank4 = new(7200, TypeAccount.Дебетовый);
            Console.WriteLine("Конструктор с 2 аргументами: decimal и TypeAccount");
            bank4.GetInfo();
            bank4.Number = 555;
            bank4.Type = TypeAccount.Инвестиционный;
            bank4.Balance = 12430;
            Console.WriteLine("Изменили через свойство: номер -  на 555, тип - на Инвестиционный и баланс  - на 12430");
            bank4.GetInfo();

            Console.WriteLine('\n');
        }
    }
}
