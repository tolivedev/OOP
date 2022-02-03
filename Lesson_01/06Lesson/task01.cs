using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._06Lesson
{
    /// <summary>
    /// Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
    /// Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). 
    /// Переопределить метод ToString() для печати информации о счете. Протестировать функционирование 
    /// переопределенных методов и операторов на простом примере.
    /// </summary>
    class task01
    {
        public task01()
        {
            new BillAcc().ControlMethod();
        }
    }

    public class BillAcc
    {

        private int _id = 0;
        private decimal _balance;
        private string _bankName;
        private string _accountType;
        private string _accountHolder;

        public BillAcc() { }

        public BillAcc(decimal balance, string bankName, string accountType, string accountHolder)
        {
            Random idd = new Random();
            _balance = balance;
            _bankName = bankName;
            _accountType = accountType;
            _accountHolder = accountHolder;
            _id = idd.Next(10000, 999999);
        }

        public int Id
        {
            get { return _id; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }


        public void Transfer(BillAcc b1, decimal count)
        {
            this._balance -= count;
            b1._balance += count;
        }



        public static bool operator ==(BillAcc b1, BillAcc b2) => b1._balance == b2._balance;
        public static bool operator !=(BillAcc b1, BillAcc b2) => b1._balance != b2._balance;

        public override int GetHashCode() => this.ToString().GetHashCode();
        public override bool Equals(object obj) => obj.ToString() == this.ToString();

        public override string ToString()
        {
            return $"Банк {_bankName} открыл счет {_accountType} c №{_id} с суммой депозита {_balance} на имя {_accountHolder}";
        }


        public void ControlMethod()
        {
            Console.WriteLine("-> Банковский счет." + '\n' + new string('-', 48));

            BillAcc b1 = new BillAcc(200, "VTB", "Depos", "Иванов И.");
            Console.WriteLine(b1.ToString());

            BillAcc b2 = new BillAcc(300, "Sber", "Cred", "Петров П.");
            Console.WriteLine(b2.ToString());

            Console.WriteLine("\n---------- выполнен перевод средств -------------");
            b1.Transfer(b2, 50);
            Console.WriteLine($"С счета {b1.Id} на счет {b2.Id} выполнен перевод средств.");
            Console.WriteLine($"Депозит счета №{b1.Id} равен {b1.Balance}, депозит счета №{b2.Id} равен {b2.Balance}");

            Console.WriteLine(new string('-', 48) + "\n--------- Сравним два счета ------------");
            Console.WriteLine($"Счет №{b1.Id} баланс {b1.Balance} == Счет №{b2.Id} баланс {b2.Balance} - результат {b1 == b2}");
            Console.WriteLine($"Счет №{b1.Id} баланс {b1.Balance} != Счет №{b2.Id} баланс {b2.Balance} - результат {b1 != b2}");
            Console.WriteLine("--------------Хеши счетов и их сравнение -------------");
            Console.WriteLine("Хеш счета {0} = {1}", b1.Id, b1.GetHashCode());
            Console.WriteLine("Хеш счета {0} = {1}", b2.Id, b2.GetHashCode());
            if (b1.Equals(b2))
            {
                Console.WriteLine("Счет {0} идентичен счету {1}" + '\n', b1.Id, b2.Id);
            }
            else
            {
                Console.WriteLine("Счет {0} не идентичен счету {1}" + '\n', b1.Id, b2.Id);
            }
            


            Console.WriteLine(new string('-', 48));
            Console.WriteLine("Для выхода - Enter...");
            Console.ReadLine();
        }
    }
}
