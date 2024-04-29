using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.NET
{
    class PaymentNegativeAmountException : ArgumentOutOfRangeException //Клас спакдоємець суперкласу стандартного вийнятку
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

        public static Payment operator +(Payment lhs, Payment rhs) //Перенавнтаження - знаходження суми дво платежів
        {
            return new Payment(lhs.amount + rhs.amount);
        }

        public double GetAmount()
        {
            return amount;
        }
    }

    class lab7_inheritException
    {
        static void Main(string[] args)
        {
             try
        {
            Payment payment1 = new Payment(-100); // Отримання вийнятку PaymentNegativeAmountException
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
