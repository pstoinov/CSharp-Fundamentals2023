using System;
using System.ComponentModel;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    add(x, y);
                    break;
                case "substract":
                    substract(x, y);
                    break;
                case "multiply":
                    multiply(x,y);
                    break;
                case "divide":
                    divide(x,y);
                    break;

            }
        }

        static void add(int x, int y) {
            Console.WriteLine(x + y);
        }

        static void substract(int x, int y) {
            Console.WriteLine(x - y);
        }
        static void multiply(int x, int y) {
            Console.WriteLine(x * y);
        }
        static void divide(int x, int y) {
            Console.WriteLine(x / y);
        }

    }
}
