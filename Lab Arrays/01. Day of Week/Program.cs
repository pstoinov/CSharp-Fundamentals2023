    using System;

    namespace _01._Day_of_Week
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n >= 8) { Console.WriteLine("Invalid day!"); }
                else { Console.WriteLine(day[n-1]); }
            }
        }
    }
