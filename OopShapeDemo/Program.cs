using System;

namespace OopShapeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Get User Inputs
                double length = GetLength();
                double? area = ShapeMenu(length);
                if (area == null) return;
                else Console.WriteLine(area.Value);
            }
        }

        static double GetLength()
        {
            double length;
            Console.Write("Enter the length of the shape's side: ");
            while (!double.TryParse(Console.ReadLine(), out length))
                Console.Write("Invalid input. Retry: ");
            return length;
        }

        static double? ShapeMenu(double length)
        {
            // Prompt user for Shape
            Console.WriteLine("Select your shape:");
            Console.WriteLine("\tA: Icosagon");
            Console.WriteLine("\tC: Circle (radius)");
            Console.WriteLine("\tB: Hexagon");
            Console.WriteLine("\tEsc: Exit Program");
            Console.Write("Choice: ");

            // Loop until valid option, if valid calculate area.
            while (true)
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape: return null;

                    case ConsoleKey.A: return new Icosagon(length).Area();

                    case ConsoleKey.C: return new Circle(length).Area();
                    case ConsoleKey.B: return new Hexagon(length).Area();
                }
        }
    }
}