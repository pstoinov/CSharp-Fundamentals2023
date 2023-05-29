using System;
using System.Collections.Specialized;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Friday":
                    if (typeOfGroup == "Students")
                    {
                        price = 8.45 * countOfPeople;
                        if (countOfPeople >= 30)
                        {
                            price = price * 0.85;
                        }
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 10.90 * countOfPeople;
                        if (countOfPeople > 100)
                        {
                            price = 10.90 * (countOfPeople - 10);
                        }
                    }
                    else if(typeOfGroup == "Regular")
                    {
                        price = 15.0 * countOfPeople;
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        price = 9.80 * countOfPeople;
                        if (countOfPeople >= 30)
                        {
                            price = price * 0.85;
                        }
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 15.60 * countOfPeople;
                        if (countOfPeople > 100)
                        {
                            price = 15.60 * (countOfPeople - 10);
                        }
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 20.0 * countOfPeople;
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        price = 10.46 * countOfPeople;
                        if (countOfPeople >= 30)
                        {
                            price = price * 0.85;
                        }
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 16.00 * countOfPeople;
                        if (countOfPeople > 100)
                        {
                            price = 16.00 * (countOfPeople - 10);
                        }
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 22.50 * countOfPeople;
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            price = price * 0.95;
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
