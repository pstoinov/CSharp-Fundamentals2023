using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(RepearString(repeatCount, input));
        }

        private static string RepearString(int repeatCount, string input)
        {
            string result = "";
            for (int i = 0; i < repeatCount; i++)
            {
                result += input;
            }
            return result;
        }

    }
}
