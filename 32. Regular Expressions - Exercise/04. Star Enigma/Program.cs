using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regexForNumMatches = new Regex(@"[sSaAtTrR]");
            int encryptedMassageCount = int.Parse(Console.ReadLine());
            string currentMassage = string.Empty;
            var attacked = new SortedDictionary<string, string>();
            var destroyed = new SortedDictionary<string, string>();

            for (int i = 0; i < encryptedMassageCount; i++)
            {
                currentMassage = Console.ReadLine();
                MatchCollection regexMatches = regexForNumMatches.Matches(currentMassage);
                int matchesNum = regexMatches.Count;
                var sb = new StringBuilder();

                char[] chars = currentMassage.ToCharArray();

                foreach (var c in chars)
                {
                    int cChar = c - matchesNum;
                    sb.Append((char)cChar);
                }
                Regex information = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*?:\d+[^@\-!:>]*?!(?<type>[A|D])![^@\-!:>]*?->\d+");
                Match match = information.Match(sb.ToString());

                if (match.Success)
                {
                    if (match.Groups["type"].Value == "A")
                    {
                        attacked.Add(match.Groups["name"].Value, match.Groups["type"].Value);
                    }
                    else
                    {
                        destroyed.Add(match.Groups["name"].Value, match.Groups["type"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var att in attacked)
            {
                Console.WriteLine($"-> {att.Key}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var dess in destroyed)
            {
                Console.WriteLine($"-> {dess.Key}");
            }
        }
    }
}
