using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int countCourses = (int)Math.Ceiling((double)countPeople / elevatorCapacity);
            Console.WriteLine(countCourses);
        }
    }
}
