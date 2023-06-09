using System;
using System.Threading.Channels;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void checkInteger(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }

        }
        static void Main(string[] args)
        {
            
            checkInteger(int.Parse(Console.ReadLine()));
        }

        
    }
}
