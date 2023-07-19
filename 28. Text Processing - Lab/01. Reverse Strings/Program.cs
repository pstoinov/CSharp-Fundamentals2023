using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                char[] charString = command.Reverse().ToArray();
                string reversedString = new string(charString);
                Console.WriteLine($"{command} = {reversedString}");
            }
        }
    }
}
