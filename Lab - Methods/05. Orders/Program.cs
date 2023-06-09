using System;
using System.Xml;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    FinalPrice(1.50, quantity );
                    break;
                case "water":
                    FinalPrice(1.0, quantity);
                    break;
                case "coke":
                    FinalPrice(1.40, quantity);
                    break;
                case "snacks":
                    FinalPrice(2.0, quantity);
                    break;
            }


        }

        static void FinalPrice(double price, double quantity)
        {
            Console.WriteLine($"{price * quantity:F2}");
        }
    }
}
