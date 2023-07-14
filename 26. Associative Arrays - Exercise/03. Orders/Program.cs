using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Product
    {
        public string Name { get; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal TotalPrice => Price * Quantity;

        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}";
        }
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
                var quantity = decimal.Parse(tokens[2]);

                if (!productList.ContainsKey(product))
                {
                    var productItem = new Product(product, price, quantity);
                    productList.Add(product, productItem);
                }
                else
                {
                    var existingProduct = productList[product];
                    existingProduct.Price = price;
                    existingProduct.Quantity += quantity;
                }
            }

            foreach (var productItem in productList.Values)
            {
                Console.WriteLine(productItem);
            }
        }
    }
}