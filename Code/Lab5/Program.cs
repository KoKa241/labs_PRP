using System;

namespace Lab5
{
    interface IDiskSystem
    {
        string Path { get; set; }
        void Delete();

        void CopyTo(string path);

        void Cut();

        void Paste(string path);

    }

    class Directory: IDiskSystem
    {
        public string Path { get; set; }

        public void Up(string path)
        {
            Path = Path + "/" + path;
        }

        public void Down()
        {
            Path = Path.Substring(0, Path.IndexOf("/"));
        }

        public void Delete()
        {
            Console.WriteLine("Видалили директорію: " + Path);
        }

        public void CopyTo(string path)
        {
            Console.WriteLine("Копіювали " + Path + " в " + path);
        }


        public void Cut()
        {
            Console.WriteLine("Вилучили " + Path);
        }


        public void Paste(string path)
        {
            Console.WriteLine("Вставили " + Path + " в " + path);
        }

    }

    class File : IDiskSystem
    {
        public string Path { get; set; }

        public void Delete()
        {
            Console.WriteLine("Видалили файл: " + Path);
        }

        public void CopyTo(string path)
        {
            Console.WriteLine("Копіювали " + Path + " в " + path);
        }

        public void Cut()
        {
            Console.WriteLine("Вилучили " + Path);
        }
        public void Paste(string path)
        {
            Console.WriteLine("Вставили " + Path + " в " + path);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IDiskSystem[] file_system = new IDiskSystem[] { new Directory(), new File() };
            file_system[0].Path = "C/Windows/System32";
            file_system[1].Path = "C/Windows/System32/run32.dll";
            foreach (IDiskSystem elem in file_system)
            {
                elem.Delete();
                elem.Cut();
            }
        }
    }
}