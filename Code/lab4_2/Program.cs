using System;

namespace lab4_2
{

    class Program
    {
        public const double PI = 3.1415;
        public abstract class Figure
        {
            public abstract string name { get; set; }
            public abstract double GetArea();

            public abstract double GetPerimeter();

        }

        public class Square : Figure
        {
            public override string name { get; set; } = "Square";
            public double Height { get; set; }
            public double Width { get; set; }

            public override double GetArea()
            {
                return Height * Width;
            }

            public override double GetPerimeter()
            {
                return 2 * (Height + Width);
            }

        }
        
        public class Circle : Figure
        {
            public override string name { get; set; } = "default_circle";


            public double Radius { get; set; }

            public override double GetPerimeter()
            {
                return Radius * 2 * PI;
            }

            public override double GetArea()
            {
                return PI * Radius * Radius;
            }


        }

        public class RightTriangle : Figure
        {
            public override string name { get; set; } = "default triangle";

            public double Base {  get; set; }

            public double Height { get; set; }

            public double Katet2 { get; set; }

            public override double GetArea()
            {
                return 0.5 * Base * Height;
            }

            public override double GetPerimeter()
            {
                return Base + Height + Katet2;
            }



        }

        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];
            Square square = new Square();
            square.Height = 10;
            square.Width = 10;
            square.name = "first";
            figures[0] = square;
            Circle circle = new Circle();
            circle.name = "circle_lab4_2";
            circle.Radius = 10;
            figures[1] = circle;
            RightTriangle triangle = new RightTriangle();
            triangle.name = "test";
            triangle.Base = 10;
            triangle.Height = 6;
            triangle.Katet2 = 3;
            figures[2] = triangle;
            foreach (Figure f in figures)
            {
                Console.WriteLine($"The area of {f.name} is  {f.GetArea()}");
                Console.WriteLine("The preimeter " + f.GetPerimeter());
            }
        }
    }
}