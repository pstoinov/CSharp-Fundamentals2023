using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Product
    {
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            var productList = new Dictionary<string, Product>();

            while ((input = Console.ReadLine()) != "buy")
            {
                var tokens = input.Split(' ');
                var product = tokens[0];
                var price = decimal.Parse(tokens[1]);
                var quantity = int.Parse(tokens[2]);

                if (!productList.ContainsKey(product))
                {
                    var productItem = new Product(price, quantity);
                    productList.Add(product, productItem);
                }
                else
                {
                    productList[product].Price = price;
                    productList[product].Quantity += quantity;
                }
            }

            foreach (var kvp in productList)
            {
                var productName = kvp.Key;
                var totalPrice = kvp.Value.Price * kvp.Value.Quantity;
                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }
        }
    }
}