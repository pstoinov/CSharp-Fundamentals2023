using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalPower = pokePower;
            int pokedTargets = 0;

            while (pokePower >= pokeDistance)
            {
                pokedTargets++;
                pokePower -= pokeDistance;

                if ((originalPower * 1.0) / 2 == pokePower)
                {
                    if (pokePower > exhaustionFactor && exhaustionFactor != 0 && exhaustionFactor != 1)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
