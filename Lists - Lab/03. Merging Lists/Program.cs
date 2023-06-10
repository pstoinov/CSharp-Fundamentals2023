using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console
                .ReadLine() 
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> joinedList = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                joinedList.Add(firstList[i]);
                joinedList.Add(secondList[i]);

            }

            if (firstList.Count > secondList.Count)
            {
                joinedList.AddRange(GetRemainingElements(firstList, secondList));
            }
            else if (firstList.Count < secondList.Count)
            {
                joinedList.AddRange(GetRemainingElements(secondList, firstList));

            }

            Console.WriteLine(string.Join(" ", joinedList));
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
                nums.Add(longerList[i]);
            return nums;
        }
    }
}
