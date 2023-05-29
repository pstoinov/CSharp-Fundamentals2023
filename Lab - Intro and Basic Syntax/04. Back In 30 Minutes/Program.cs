using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int allmintues = (hours * 60) + minutes + 30;

            int afterHours = allmintues / 60;
            int afterMinutes = allmintues % 60;
            if (afterHours > 23) 
            {
                afterHours = 0;
            }

            if (afterMinutes < 10)
            {
                Console.WriteLine($"{afterHours}:0{afterMinutes}");
            }
            else
            Console.WriteLine($"{afterHours}:{afterMinutes}");



        }
    }
}
