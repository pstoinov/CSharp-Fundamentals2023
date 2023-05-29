using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)

            int orders = int.Parse(Console.ReadLine());
            
            decimal totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsule = int.Parse(Console.ReadLine());
                decimal currentPrice = ((days * countCapsule) * priceCapsule);
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");



        }
    }
}
