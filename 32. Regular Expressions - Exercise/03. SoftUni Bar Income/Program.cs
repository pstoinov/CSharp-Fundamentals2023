using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex barIncomeFilter = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|%$.]*<(?<product>\w+)>[^|%$.]*\|(?<count>\d+)\|[^|%$.]*?(?<price>\d+\.?\d+)\$");
            decimal sum = 0m;

            string currentInput;

            while ((currentInput = Console.ReadLine()) != "end of shift")
            {
                Match match = barIncomeFilter.Match(currentInput);
                if (match.Success)
                {
                    string name = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {(price * count):f2}");
                    sum += price * count;
                }
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
