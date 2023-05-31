using System;
using System.ComponentModel.Design;

namespace _12_Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sumOfDigits = 0;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                bool isSpecial;
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                }
                else { isSpecial = false; }
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }
        }
    }
}
