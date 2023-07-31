using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, List<string>>();
            var enrollmentOrder = new Dictionary<string, int>();
            int counter = 1;

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splitInput = input.Split();
                string command = splitInput[0];

                if (command == "Enroll")
                {
                    string name = splitInput[1];
                    if (!heroes.ContainsKey(name))
                    {
                        heroes[name] = new List<string>();
                        enrollmentOrder[name] = counter;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already enrolled.");
                    }
                }

                if (command == "Learn")
                {
                    string name = splitInput[1];
                    string spell = splitInput[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (!heroes[name].Contains(spell))
                        {
                            heroes[name].Add(spell);
                            enrollmentOrder[name + spell] = counter;
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine($"{name} has already learnt {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }

                if (command == "Unlearn")
                {
                    string name = splitInput[1];
                    string spell = splitInput[2];
                    if (heroes.ContainsKey(name))
                    {
                        if (heroes[name].Contains(spell))
                        {
                            heroes[name].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{name} doesn't know {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes.OrderBy(x => enrollmentOrder[x.Key]))
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value.OrderBy(spell => enrollmentOrder[hero.Key + spell]))}");
            }
        }
    }
}
