using System;

class Program
{
    static void Main()
    {
        int startingYield = int.Parse(Console.ReadLine());
        int daysOperated = 0;
        int totalSpiceExtracted = 0;

        while (startingYield >= 100)
        {
            totalSpiceExtracted += startingYield - 26;
            startingYield -= 10;
            daysOperated++;
        }

        if (totalSpiceExtracted >= 26)
        {
            totalSpiceExtracted -= 26;
        }
        else
        {
            totalSpiceExtracted = 0;
        }

        Console.WriteLine(daysOperated);
        Console.WriteLine(totalSpiceExtracted);
    }
}