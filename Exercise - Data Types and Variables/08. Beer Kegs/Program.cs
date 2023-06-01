using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte countKegs = byte.Parse(Console.ReadLine());
            string biggestKeg = "";
            double kegBiggestVolume = double.MinValue; 
            for (int i = 0; i < countKegs; i++)
            {
                string keg = (Console.ReadLine());
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());
                double volumeKeg = Math.PI * (radiusKeg*radiusKeg) * heightKeg;
                if (volumeKeg >= kegBiggestVolume)
                {
                    biggestKeg = keg;
                    kegBiggestVolume = volumeKeg;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
