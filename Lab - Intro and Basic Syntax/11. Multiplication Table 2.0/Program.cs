using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            
                if (num > 10)
                {
                    Console.WriteLine($"{multiplier} X {num} = {multiplier * num}");
                }
                else 
                {
                for (int i = num; i <= 10; i++)
                {

                    Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
                }
                }
        }
    }
}
