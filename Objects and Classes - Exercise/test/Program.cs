using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine()!);

            string result = age switch
            {
                >= 0 and <= 2 => "baby",
                >= 3 and <= 13 => "child",
                >= 14 and <= 19 => "teenager",
                >= 20 and <= 65 => "adult",
                >= 66 => "elder",
                _ => throw new ArgumentOutOfRangeException()
            };

            Console.WriteLine(result);
        }
    }
}