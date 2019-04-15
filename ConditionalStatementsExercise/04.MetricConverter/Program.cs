using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputmetric = Console.ReadLine();
            string outputmetric = Console.ReadLine();
            inputmetric = inputmetric.ToLower();
            outputmetric = outputmetric.ToLower();
            if (inputmetric == "mm")
            {
                value = value / 1000;
            }
            else if (inputmetric == "cm")
            {
                value = value / 100;
            }
            if (outputmetric == "mm")
            {
                value = value * 1000;
            }
            else if (outputmetric == "cm")
            {
                value = value * 100;
            }

            Console.WriteLine($"{value:F3}");
        }
    }
}
