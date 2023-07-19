using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, regex);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
