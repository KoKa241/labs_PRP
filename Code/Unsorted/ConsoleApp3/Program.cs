using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix_1 = new int[5, 5];
            int[,] matrix_2 = new int[5, 5];
            int[,] matrix_3 = new int[5, 5];
            int n = 3;
            for (int i = 0; i < matrix_1.GetLength(0); i++) //создаём выводим матрицу 1
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                {
                    matrix_1[i, j] = random.Next(50);
                    matrix_2[i, j] = random.Next(50);
                }
            }

            for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                {
                    Console.Write(matrix_1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < matrix_2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_2.GetLength(1); j++)
                {
                    Console.Write(matrix_2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Множення матриці на число");

            for (int i = 0; i < matrix_2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_2.GetLength(1); j++)
                {
                    Console.Write(matrix_1[i, j] * n + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Сума матриць");

            for (int i = 0; i < matrix_2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_2.GetLength(1); j++)
                {
                    matrix_3[i, j] = matrix_2[i, j] + matrix_1[i, j];
                    Console.Write(matrix_3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Добуток матриць");

            for (int i = 0; i < matrix_2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_2.GetLength(1); j++)
                {
                    matrix_3[i, j] = matrix_2[i, j] * matrix_1[i, j];
                    Console.Write(matrix_3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
