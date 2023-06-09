using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(a, b));
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
