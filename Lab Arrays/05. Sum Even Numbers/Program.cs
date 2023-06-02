using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(n => n % 2 == 0).ToArray();
            int sumEvenNumbers = 0;
            foreach (int item in numbers)
            {
                sumEvenNumbers += item;
            }
            Console.WriteLine(sumEvenNumbers);
        }
    }
}
