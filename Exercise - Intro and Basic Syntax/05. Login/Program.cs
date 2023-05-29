using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            int wrongPassCount = 0;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }
            while (true)
            {
                
                string typePassword = Console.ReadLine();
                if (typePassword != password)
                {
                    wrongPassCount++;
                    if (wrongPassCount == 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                
            }
        }
    }
}
