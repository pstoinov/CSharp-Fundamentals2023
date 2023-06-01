using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numSnowballs = int.Parse(Console.ReadLine());

            BigInteger highestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < numSnowballs; i++)
            {
                int snowSnowball = int.Parse(Console.ReadLine());
                int timeSnowball = int.Parse(Console.ReadLine());
                int qualitySnowball = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowSnowball / timeSnowball, qualitySnowball);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    bestSnow = snowSnowball;
                    bestTime = timeSnowball;
                    bestQuality = qualitySnowball;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {highestValue} ({bestQuality})");
        }
    }
}







