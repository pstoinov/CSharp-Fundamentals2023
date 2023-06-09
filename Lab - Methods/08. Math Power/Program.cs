using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(num, power));
        }

        static double RiseToPower(double num, int pow)
        {
            double result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *=num;
            }
            return result;
        }
    }
}
