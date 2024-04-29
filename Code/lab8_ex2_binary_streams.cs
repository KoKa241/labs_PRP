using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        // Створення та заповнення файлу з випадковими числами
        using (BinaryWriter writer = new BinaryWriter(File.Open(inputFile, FileMode.Create)))
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                writer.Write(random.Next(-10, 11));
            }
        }

        // Отримання статистики з файлу
        Dictionary<int, int> statistics = new Dictionary<int, int>();
        using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                int number = reader.ReadInt32();
                if (!statistics.ContainsKey(number))
                {
                    statistics[number] = 1;
                }
                else
                {
                    statistics[number]++;
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
    }
}
