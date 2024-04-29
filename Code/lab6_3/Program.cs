using System;

namespace lab6_3
{
    class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardOwner { get; set; }
        public string ExpiryDate { get; set; }

        public string PIN { get; set; }

        public double CreditLimit { get; set; }

        public double Balance { get; set; }

        public void AddMoney(double amount)
        {
            Balance += amount;
        }

        public void RemoveMoney(double amount)
        {
            if (Balance - amount < 0)
            {
                Balance -= amount;
                RemoveFromCreditLimit(-Balance);
                Balance = 0;
            }
            else
            {
                Balance -= amount;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }

        private void RemoveFromCreditLimit(double amount)
        {
            CreditLimit -= amount;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}