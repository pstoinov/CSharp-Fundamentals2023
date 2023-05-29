using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = lostGamesCount / 2;
            int trashedMice = lostGamesCount / 3;
            int trashedKeyboards = lostGamesCount / 6;
            int trashedDisplays = trashedKeyboards / 2;

            double expenses = trashedHeadsets * headsetPrice +
                trashedMice * mousePrice +
                trashedKeyboards * keyboardPrice +
                trashedDisplays * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}