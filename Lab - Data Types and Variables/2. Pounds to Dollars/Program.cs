﻿using System;

namespace _2._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double result = pounds * 1.31;
            Console.WriteLine($"{result:F3}");
        }
    }
}
