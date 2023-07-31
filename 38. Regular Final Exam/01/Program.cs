using System;
using System.Collections;
using System.Diagnostics;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                var commandArg = command.Split(' ');

                if (commandArg[0] == "Change")
                {
                    var c = char.Parse(commandArg[1]);
                    var r = char.Parse(commandArg[2]);
                    input = input.Replace(c, r);
                    Console.WriteLine(input);
                }

                if (commandArg[0] == "Includes")
                {
                    var include = commandArg[1];
                    bool isIncluded = input.Contains(include);
                    Console.WriteLine(isIncluded);
                }

                if (commandArg[0] == "End")
                {
                    var endingString = commandArg[1];
                    bool isTrue = input.EndsWith(endingString);
                    Console.WriteLine(isTrue);
                }

                if (commandArg[0] == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }

                if (commandArg[0] == "FindIndex")
                {
                    var indexToBeFound = char.Parse(commandArg[1]);
                    Console.WriteLine(input.IndexOf(indexToBeFound));
                }

                if (commandArg[0] == "Cut")
                {
                    var startIndex = int.Parse(commandArg[1]);
                    var count = int.Parse(commandArg[2]);

                    Console.WriteLine(input.Substring(startIndex, count));
                }
            }
        }
    }
}
