using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            bool isSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                while (num > 0) 
                {
                    int lastDigit = num % 10;
                    sumOfDigits += lastDigit;
                    num /= 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11) 
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
                isSpecial = false;
                sumOfDigits = 0;
               
            }
        }
    }
}
