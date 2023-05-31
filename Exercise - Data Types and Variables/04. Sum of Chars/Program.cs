using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte coutChar = byte.Parse(Console.ReadLine());
            int sumASCII = 0;
            for (int i = 1; i <= coutChar; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int ascii = (int)ch;
                sumASCII += ascii;
            }
            Console.WriteLine($"The sum equals: {sumASCII}");
        }
    }
}
