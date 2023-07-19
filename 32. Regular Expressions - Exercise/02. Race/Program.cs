using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02._Race
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> players = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = EmplementName(input);
                int kilometer = EmplementKilometers(input);
                if (players.ContainsKey(name))
                {
                    players[name] += kilometer;
                }

            }

            int count = 0;
            foreach (var item in players.OrderByDescending(x => x.Value))
            {
                count++;
                string tag = count == 1 ? "1st" : count == 2 ? "2nd" : "3rd";

                Console.WriteLine($"{tag} place: {item.Key}");
                if (count == 3)
                {
                    break;
                }
            }
        }


        public static int EmplementKilometers(string input)
        {
            Regex kilometers = new Regex(@"\d");
            MatchCollection matches = kilometers.Matches(input);
            int sum = 0;
            foreach (Match item in matches)
            {
                sum += int.Parse(item.Value);
            }

            return sum;
        }

        public static string EmplementName(string input)
        {
            Regex name = new Regex(@"[A-Za-z]");
            MatchCollection matches = name.Matches(input);
            var sb = new StringBuilder();
            foreach (Match simbol in matches)
            {
                sb.Append(simbol.Value);
            }

            return sb.ToString();
        }

    }
}
    

