using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = new List<string>(Console.ReadLine().Split(", "));
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string replacement = new string('*', word.Length);
                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);

        }
    }
}
