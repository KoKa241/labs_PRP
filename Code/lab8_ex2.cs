using System;
using System.IO;
using System.Collections.Generic;
//Варіант з байтовими потоками
class Program
{
    static void Main(string[] args)
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        // Створення та заповнення файлу з випадковими числами
        using (FileStream fs = new FileStream(inputFile, FileMode.Create))
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                byte[] bytes = BitConverter.GetBytes(random.Next(-10, 11));
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        // Отримання статистики з файлу
        Dictionary<int, int> statistics = new Dictionary<int, int>();
        using (FileStream fs = new FileStream(inputFile, FileMode.Open))
        {
            byte[] buffer = new byte[4];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                int number = BitConverter.ToInt32(buffer, 0);
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
        Console.ReadLine();
    }
}