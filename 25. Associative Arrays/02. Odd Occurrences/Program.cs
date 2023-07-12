using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerCase = word.ToLower();
                if (!counts.ContainsKey((lowerCase)))
                {
                    counts[lowerCase] = 0;
                }
                counts[lowerCase]++;
            }

            foreach (var kvp in counts)
            {
                if (kvp.Value % 2 == 0) 
                {
                    continue;
                }

                Console.Write(kvp.Key + " ");
            }
        }
    }
}
