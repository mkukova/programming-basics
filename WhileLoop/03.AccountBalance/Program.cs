using System;

namespace _03.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDeposits = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0.0;
            while (counter < numberDeposits)
            {
                double amount = double.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += amount;
                Console.WriteLine($"Increase: {amount:F2}");
                counter++;
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
