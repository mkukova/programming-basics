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
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (friut == "banana")
                {
                    price = 2.5;
                }
                else if (friut == "kiwi")
                {
                    price = 2.7;
                }
                else if (friut == "apple")
                {
                    price = 1.2;
                }
                else if (friut == "orange")
                {
                    price = 0.85;
                }
                else if (friut == "grapefruit")
                {
                    price = 1.45;
                }
                else if (friut == "pineapple")
                {
                    price = 5.5;
                }
                else if (friut == "grapes")
                {
                    price = 3.85;
                }

            }
            else if (day == "sunday" || day == "saturday")
            {
                if (friut == "banana")
                {
                    price = 2.7;
                }
                else if (friut == "kiwi")
                {
                    price = 3;
                }
                else if (friut == "apple")
                {
                    price = 1.25;
                }
                else if (friut == "orange")
                {
                    price = 0.9;
                }
                else if (friut == "grapefruit")
                {
                    price = 1.6;
                }
                else if (friut == "pineapple")
                {
                    price = 5.6;
                }
                else if (friut == "grapes")
                {
                    price = 4.2;
                }
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
