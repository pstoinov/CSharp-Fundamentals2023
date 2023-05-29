using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabre = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double costLightsabre = Math.Ceiling(countOfStudents * 1.1) * lightsabre;
            double costRobes = countOfStudents * robes;
            int freeBelts = countOfStudents / 6;
            double costBelts = (countOfStudents - freeBelts) * belts;
            
            double totalCost = costLightsabre + costRobes + costBelts;
            if (totalCost <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCost - amountOfMoney:F2}lv more.");
            }
        }
    }
}
