using System;
using System.IO;

namespace Learn.NET
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fileText = ReadFile();
            string outputText = "";
            Console.WriteLine(fileText);
            bool newSentence = true;
            bool spacePending = false;
            foreach (char symbol in fileText)
            {
                string symbol_new = symbol.ToString();
                if (char.IsWhiteSpace(symbol))
                {
                    spacePending = true;
                    continue;
                }
                else if (symbol == ',' || symbol == '?' || symbol == '!' || symbol == '.')
                {
                    spacePending = false;
                    newSentence = true;
                }
                else if (newSentence)
                {
                    if (char.IsWhiteSpace(symbol))
                    {
                        continue;
                    }
                    else
                    {
                        if (spacePending && symbol != '-')
                        {

                            outputText += " ";
                            spacePending = false;
                        }
                        newSentence = false;
                        outputText += symbol.ToString().ToUpper();
                        continue;
                    }

                }

                if (spacePending && symbol != '-')
                {

                    outputText += " ";
                    spacePending = false;
                }

                outputText += symbol;
            }
            Console.WriteLine(outputText);

            // Запис результату у файл "output.txt"
            WriteToFile("output.txt", outputText);

            Console.ReadLine();
        }

        public static string ReadFile()
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                return reader.ReadToEnd();
            }
        }

        public static void WriteToFile(string fileName, string text)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(text);
            }
        }
    }
}
