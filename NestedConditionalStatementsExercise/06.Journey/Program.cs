using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spentAmount = 0.0;
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        spentAmount = 0.3 * budget;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {spentAmount:F2}");
                        break;
                    case "winter":
                        spentAmount = 0.7 * budget;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {spentAmount:F2}");
                        break;
					default:
						Console.WriteLine("Invalid season");
						break;					
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        spentAmount = 0.4 * budget;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Camp - {spentAmount:F2}");
                        break;
                    case "winter":
                        spentAmount = 0.8 * budget;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {spentAmount:F2}");
                        break;
					default:
						Console.WriteLine("Invalid season");
						break;
                }
            }
            else
            {
                spentAmount = 0.9 * budget;
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {spentAmount:F2}");
            }
        }
    }
}

