using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte stop = byte.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
