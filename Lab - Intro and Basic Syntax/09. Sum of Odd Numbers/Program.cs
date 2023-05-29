using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int oddNumber = 2 * i - 1;
                Console.WriteLine(oddNumber);
                sum += oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
