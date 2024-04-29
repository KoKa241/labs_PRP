using System;

namespace lab6_2
{
    class Program
    {
        delegate bool IsDay(DateTime date);
        static void Main(string[] args)
        {
            
            IsDay isProgrammerDay = delegate (DateTime date)
            {
                return date.DayOfYear == 256;
            };


            DateTime checkDate = new DateTime(2024, 9, 12);

            if (isProgrammerDay(checkDate))
            {
                Console.WriteLine("This is programmer day!");
            }
            else
            {
                Console.WriteLine("This is not programmer day!");
            }



        }
    }
}