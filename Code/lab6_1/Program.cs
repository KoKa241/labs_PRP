using System;
using System.Collections.Generic;

namespace lab6_1{

    delegate bool Filter(int x);

    class NumArray {

        public static List<int> GetStepenTwo(int[] array)
        {
            return FilterNums(array, IsStepenTwo);
        }


        public static List<int> GetTwoDigit(int[] array)
        {
            return FilterNums(array, IsTwoDigit);
        }


        public static List<int> FilterNums(int[] nums, Filter f)
        {
            List<int> result = new List<int>();

            foreach (int x in nums)
            {
                if (f(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        private static bool IsStepenTwo(int x)
        {
            return (x!=0) && ((x & (x - 1)) == 0);
        }


        private static bool IsTwoDigit(int x)
        {
            return x>=10 && x<100;
        }

    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int[] numbers = { 1, 2, 3, 4, 5, 10, 16, 25, 64, 99 };

            List<int> stepenTwoNums = NumArray.GetStepenTwo(numbers);
            Console.WriteLine("Stepen two numbers: ");
            foreach (int x in stepenTwoNums)
            {
                Console.WriteLine(x);
            }


            List<int> twoDigitNums = NumArray.GetTwoDigit(numbers);
            Console.WriteLine("Two digit numbers: ");
            foreach (int x in twoDigitNums)
            {
                Console.WriteLine(x);
            }



        }
    }
}