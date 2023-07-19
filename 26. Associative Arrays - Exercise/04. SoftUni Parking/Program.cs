using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            RegisterUnregister(users);
            Print(users);
        }

        static void RegisterUnregister(Dictionary<string, string> users)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "register")
                {
                    if (users.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users.First(x => x.Key == command [1]).Value}");
                    }
                    else
                    {
                        users.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (users.ContainsKey(command[1]))
                    {
                        users.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
        }

        static void Print(Dictionary<string, string> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
