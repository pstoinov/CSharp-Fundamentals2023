using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[wagons];
            for (int i = 0; i < passangers.Length; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", passangers));
            Console.WriteLine(passangers.Sum());
        }
    }
}
