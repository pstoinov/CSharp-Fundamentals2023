using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double price = 0;
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input != "Start")
                {
                    if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                    {
                        double coin = double.Parse(input);
                        sum += coin;
                    }
                    else { Console.WriteLine($"Cannot accept {input}"); }
                }
                else 
                {
                    break;
                }
            }

            while (true)
            {
                input = Console.ReadLine();
                if(input != "End")
                {
                    if (input == "Nuts")
                    {
                        price = 2.0;
                    }
                    else if (input == "Water")
                    {
                        price = 0.7;
                    }
                    else if (input == "Crisps")
                    {
                        price = 1.5;
                    }
                    else if (input == "Soda")
                    {
                        price = 0.80;
                    }
                    else if (input == "Coke")
                    {
                        price = 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                        continue;
                    }

                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}");
                        sum -= price;
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Change: {sum:F2}");


        }
    }
}
