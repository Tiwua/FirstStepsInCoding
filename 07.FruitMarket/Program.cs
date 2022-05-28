using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_PER_LITER_FUEL = 2.10;
            const double PRICE_FOR_GUIDE = 100;


            double budget = double.Parse(Console.ReadLine());
            double liters = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double priceOfLiters = liters * PRICE_PER_LITER_FUEL;
            double totalSum = priceOfLiters * PRICE_FOR_GUIDE;

            if (day == "Saturday")
            {
                totalSum *= 0.9;

            }
            else if (day == "Sunday")
            {
                totalSum *= 0.8;
            }
            if (totalSum <= budget)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded} lv.");
            }


        }
    }
}
