﻿using System;

namespace _4._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int years = n * 100;
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            int minutes = (int)(hours * 60);

            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
