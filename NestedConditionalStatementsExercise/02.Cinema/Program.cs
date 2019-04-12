using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (type == "premiere")
            {
                income = rows * colums * 12.00;
            }
            else if (type == "normal")
            {
                income = rows * colums * 7.50;
            }
            else if (type == "discount")
            {
                income = rows * colums * 5.00;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
