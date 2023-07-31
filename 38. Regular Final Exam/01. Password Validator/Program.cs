using System;
using System.Linq;

namespace _01._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] cmdArgs = command.Split();

                if (cmdArgs[0] == "Make" && cmdArgs[1] == "Upper")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < password.Length)
                    {
                        char upperChar = char.ToUpper(password[index]);
                        password = password.Remove(index, 1).Insert(index, upperChar.ToString());
                        Console.WriteLine(password);
                    }
                }
                else if (cmdArgs[0] == "Make" && cmdArgs[1] == "Lower")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < password.Length)
                    {
                        char lowerChar = char.ToLower(password[index]);
                        password = password.Remove(index, 1).Insert(index, lowerChar.ToString());
                        Console.WriteLine(password);
                    }
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    char ch = cmdArgs[2][0];
                    if (index >= 0 && index <= password.Length)
                    {
                        password = password.Insert(index, ch.ToString());
                        Console.WriteLine(password);
                    }
                }
                else if (cmdArgs[0] == "Replace")
                {
                    char oldChar = cmdArgs[1][0];
                    int value = int.Parse(cmdArgs[2]);
                    char newChar = (char)(oldChar + value);
                    password = password.Replace(oldChar, newChar);
                    Console.WriteLine(password);
                }
                else if (cmdArgs[0] == "Validation")
                {

                    if (password.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }

                    if (!password.All(c => char.IsLetterOrDigit(c) || c == '_'))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }

                    if (!password.Any(c => char.IsUpper(c)))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }

                    if (!password.Any(c => char.IsLower(c)))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }

                    if (!password.Any(c => char.IsDigit(c)))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }

                   
                }

                command = Console.ReadLine();
            }
        }
    }
}
