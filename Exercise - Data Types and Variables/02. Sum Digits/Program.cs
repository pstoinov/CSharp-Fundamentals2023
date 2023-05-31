using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                sumDigits += lastDigit;
                num /= 10;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
