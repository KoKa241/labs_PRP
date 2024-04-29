using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1, y1, x2, y2, x3, y3: ");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float x3 = float.Parse(Console.ReadLine());
            float y3 = float.Parse(Console.ReadLine());

            float perimeter = triangle_point_perimeter(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("Perimeter: " + perimeter);
        }

        public static float triangle_point_perimeter(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            float side1, side2, side3, semiperimeter, perimeter;

            side1 = MathF.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            side2 = MathF.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            side3 = MathF.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            perimeter = side1 + side2 + side3;

            return MathF.Round(perimeter);
        }
    }
}