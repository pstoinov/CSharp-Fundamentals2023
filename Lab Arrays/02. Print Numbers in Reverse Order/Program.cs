using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];


        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        numbers = numbers.Reverse().ToArray();
        Console.WriteLine(string.Join(' ', numbers));
    }
}
