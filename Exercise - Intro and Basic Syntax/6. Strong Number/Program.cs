using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int originalNum = num;
            int factorial = 1;

            while (num > 0)
            {
                int digit = num % 10;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                num /= 10;
                factorial = 1;
            }
            if (sum == originalNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
