using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().Replace(" ", "").ToCharArray();
            var dictionary = new Dictionary<char, int>();

            foreach (char c in charArray)
            {
                if (!dictionary.ContainsKey(c))
                {
                    dictionary[c] = 0;
                }
                dictionary[c]++;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
