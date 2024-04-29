using System;

namespace Learn.NET
{

    class PaymentNegativeAmountException : Exception
    {
        public PaymentNegativeAmountException() : base("Сума платежу не може бути меншою або дорівнювати 0.") { }
    }

    class Payment
    {
        private double amount;

        public Payment(double amount)
        {
            if (amount <= 0)
            {
                throw new PaymentNegativeAmountException();
            }
            this.amount = amount;
        }

        public static Payment operator +(Payment lhs, Payment rhs)
        {
            return new Payment(lhs.amount + rhs.amount);
        }

        public double GetAmount()
        {
            return amount;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Payment payment1 = new Payment(-100); // Гереація винятку PaymentNegativeAmountException
            }
            catch (PaymentNegativeAmountException ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }

            Payment payment2 = new Payment(200);
            Payment payment3 = new Payment(300);
            Payment totalPayment = payment2 + payment3;

            Console.WriteLine("Загальна сума платежу: " + totalPayment.GetAmount());
            Console.ReadLine();
        }
    }
}
