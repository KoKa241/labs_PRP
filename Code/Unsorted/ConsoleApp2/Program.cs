using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Random random = new Random();

            int[] daily_production = new int[10];
            for (int i = 0; i < daily_production.Length; i++)
            {
                daily_production[i] = random.Next(50);
                Console.Write(daily_production[i] + " ");
            }
            int counter = 0;
            double norm = 37 + (37 * 0.1);
            for (int i = 0; i < daily_production.Length; i++)
            {
                if (daily_production[i] > norm)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Перевиконали норму стiльки робiтникiв {counter}");
            Console.ReadLine();

        }
    }
}
