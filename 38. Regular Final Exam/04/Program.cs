using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, List<string>>();
            var enrollmentOrder = new Dictionary<string, int>();
            int counter = 1;

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitInput = input.Split();
                string command = splitInput[0];

                switch (command)
                {
                    case "Enroll":
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
                        break;

                    case "Learn":
                        name = splitInput[1];
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
                        break;

                    case "Unlearn":
                        name = splitInput[1];
                        spell = splitInput[2];
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
                        break;

                    
                }

                
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes.OrderBy(x => enrollmentOrder[x.Key]))
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value.OrderBy(spell => enrollmentOrder[hero.Key + spell]))}");
            }
        }
    }
}
