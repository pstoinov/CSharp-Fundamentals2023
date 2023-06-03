using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                arr1[i] = input[0];
                arr2[i] = input[1];
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    int temp = arr1[i];
                    arr1[i] = arr2[i];
                    arr2[i] = temp;
                }
            }

            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}