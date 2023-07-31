using System;
using System.Text.RegularExpressions;

namespace _05._Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string regexPattern = @"([|])([A-Z]{4,})\1:([#])([a-zA-Z]+ [a-zA-Z]+)\3";
            Regex regex = new Regex(regexPattern);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string boss = match.Groups[2].Value;
                    string title = match.Groups[4].Value;

                    Console.WriteLine($"{boss}, The {title}");
                    Console.WriteLine($">> Strength: {boss.Length}");
                    Console.WriteLine($">> Armor: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
