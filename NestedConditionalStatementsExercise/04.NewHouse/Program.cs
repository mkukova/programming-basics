using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numberFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost = 0.0;
            double discount = 0.0;
            double moreExpensive = 0.0;
            double leftMoney = 0.0;
            double neededMoney = 0.0;
            switch (typeFlower)
            {
                case "Roses":
                    cost = numberFlower * 5.0;
                    if (numberFlower > 80)
                    {
                        discount = 0.1 * cost;
                        cost = cost - discount;
                    }
                    break;
                case "Dahlias":
                    cost = numberFlower * 3.80;
                    if (numberFlower > 90)
                    {
                        discount = 0.15 * cost;
                        cost = cost - discount;
                    }
                    break;
                case "Tulips":
                    cost = numberFlower * 2.80;
                    if (numberFlower > 80)
                    {
                        discount = 0.15 * cost;
                        cost = cost - discount;
                    }
                    break;
                case "Narcissus":
                    cost = numberFlower * 3.00;
                    if (numberFlower < 120)
                    {
                        moreExpensive = 0.15 * cost;
                        cost = cost + moreExpensive;
                    }
                    break;
                case "Gladiolus":
                    cost = numberFlower * 2.50;
                    if (numberFlower < 80)
                    {
                        moreExpensive = 0.2 * cost;
                        cost = cost + moreExpensive;
                    }
                    break;
            }

            if (cost <= budget)
            {
                leftMoney = budget - cost;
                Console.WriteLine($"Hey, you have a great garden with {numberFlower} {typeFlower} and {leftMoney:F2} leva left.");
            }
            else
            {
                neededMoney = cost - budget;
                Console.Write($"Not enough money, you need {neededMoney:F2} leva more.");
            }

        }
    }
}
