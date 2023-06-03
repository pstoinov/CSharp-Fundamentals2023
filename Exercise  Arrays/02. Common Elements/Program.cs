using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(" ").ToArray();
            string output = "";

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j] == arr2[i])
                    {
                        output += arr1[j] + " ";
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
