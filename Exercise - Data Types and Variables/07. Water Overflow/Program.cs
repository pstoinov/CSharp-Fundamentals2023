
using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int filledWater = 0;

            for (int i = 0; i < n; i++)
            {
                int litersWater = int.Parse(Console.ReadLine());

                if (litersWater + filledWater <= 255)
                {
                    filledWater += litersWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(filledWater);
        }
    }
}