using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            while (secondString.Contains(firstString))
            {
                secondString = secondString.Replace(firstString, string.Empty);
            }

            Console.WriteLine(secondString);
        }
    }
}
