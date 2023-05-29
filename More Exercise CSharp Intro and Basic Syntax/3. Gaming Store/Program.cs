using System;

namespace _3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price, spent = 0;
            string input = "";

            while (input != "Game Time")
            {
                input = Console.ReadLine();
                if (input != "Game Time")
                {
                    switch (input)
                    {
                        case "OutFall 4":
                            price = 39.99;
                            break;
                        case "CS: OG":
                            price = 15.99;
                            break;
                        case "Zplinter Zell":
                            price = 19.99;
                            break;
                        case "Honored 2":
                            price = 59.99;
                            break;
                        case "RoverWatch":
                            price = 29.99;
                            break;
                        case "RoverWatch Origins Edition":
                            price = 39.99;
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            continue;
                            //break;
                    }
                    if (price <= budget)
                    {
                        budget -= price;

                        spent += price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    Console.WriteLine($"Bought {input}");
                    if (budget <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Total spent: ${spent}. Remaining: ${budget:F2}");
                }
            }
        }
    }
}
