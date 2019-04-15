using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int fishers = int.Parse(Console.ReadLine());
            double currentPrice = 0.0;
            double discount = 0.0;
            double finalPrice = 0.0;

            switch (season)
            {
                case "spring":
                    currentPrice = 3000; break;
                case "summer":
                    currentPrice = 4200; break;
                case "autumn":
                    currentPrice = 4200; break;
                case "winter":
                    currentPrice = 2600; break;
            }

            if (fishers <= 6)
            {
                discount = 0.1 * currentPrice;
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                discount = 0.15 * currentPrice;
            }
            else
            {
                discount = 0.25 * currentPrice;
            }

            finalPrice = currentPrice - discount;

            if ((fishers % 2 == 0) && (season != "autumn"))
            {
                finalPrice = finalPrice - (0.05 * finalPrice);
            }

            if (finalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - finalPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(finalPrice - budget):F2} leva.");
            }

        }
    }
}
