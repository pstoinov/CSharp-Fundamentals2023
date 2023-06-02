using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumEven = inputNums.Where(n  => n % 2 == 0).Sum();
            int sumOdd = inputNums.Where(n => n % 2 == 1).Sum();
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
