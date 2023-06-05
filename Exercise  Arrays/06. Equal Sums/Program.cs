using System;
using System.Linq;

namespace _06._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                int rightSum = 0;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine(index);
            else
                Console.WriteLine("no");

        }
    }
}
