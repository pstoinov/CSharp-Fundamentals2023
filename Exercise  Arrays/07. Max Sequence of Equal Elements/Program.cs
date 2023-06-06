using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLength = 0;
        int maxStartIndex = 0;

        int currentLength = 1;
        int currentStartIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                }
            }
            else
            {
                currentLength = 1;
                currentStartIndex = i;
            }
        }

        int[] longestSequence = arr.Skip(maxStartIndex).Take(maxLength).ToArray();


        Console.WriteLine(string.Join(" ", longestSequence));
    }
}