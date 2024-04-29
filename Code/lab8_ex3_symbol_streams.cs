using System;
using System.IO;
using System.Collections.Generic;
//Варіант з символьними потоками
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        // Створення та заповнення файлу з випадковими числами
        using (StreamWriter writer = new StreamWriter(inputFile))
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                writer.Write(random.Next(-10, 11) + " ");
            }
        }

        // Отримання статистики з файлу
        Dictionary<int, int> statistics = new Dictionary<int, int>();
        using (StreamReader reader = new StreamReader(inputFile))
        {
            string line = reader.ReadLine();
            string[] numbers = line.Split(' ');
            foreach (string num in numbers)
            {
                try
                {
                    int n = int.Parse(num);
                    if (!statistics.ContainsKey(n))
                    {
                        statistics[n] = 1;
                    }
                    else
                    {
                        statistics[n]++;
                    }
                }
                catch(System.FormatException e)
                {
                    continue;
                }
                
            }
        }

        // Виведення статистики на консоль та запис у вихідний файл
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (var pair in statistics)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
                writer.WriteLine($"{pair.Key}, {pair.Value}");
            }
        }
        Console.ReadLine();
    }
}