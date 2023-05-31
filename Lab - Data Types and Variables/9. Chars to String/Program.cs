using System;

namespace _9._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string allChars = a.ToString() + b.ToString() + c.ToString();
            Console.WriteLine(allChars);
        }
    }
}
