using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rotations; i++)
            //{
            //    int firstElement = array[0];

            //    for (int j = 0; j < array.Length - 1; j++)
            //    {
            //        array[j] = array[j + 1];
            //    }

            //    array[array.Length - 1] = firstElement;
            //}
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }

                array[^1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}