using System;

namespace _06.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string friut = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    switch (friut)
                    {
                        case "banana":
                            price = 2.5;
                            break;
                        case "kiwi":
                            price = 2.7;
                            break;
                        case "apple":
                            price = 1.2;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "pineapple":
                            price = 5.5;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                    }

                    break;
                case "sunday":
                case "saturday":
                    switch (friut)
                    {
                        case "banana":
                            price = 2.7;
                            break;
                        case "kiwi":
                            price = 3.0;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.9;
                            break;
                        case "grapefruit":
                            price = 1.6;
                            break;
                        case "pineapple":
                            price = 5.6;
                            break;
                        case "grapes":
                            price = 4.2;
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

            if (price > 0)
            {
                double sum = price * quantity;
                Console.WriteLine($"{sum:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
