using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits.Append(c);
                }
                else if (char.IsLetter(c))
                {
                    letters.Append(c);
                }
                else
                {
                    others.Append(c);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
