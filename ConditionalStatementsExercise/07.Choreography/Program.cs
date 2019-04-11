using System;

namespace _07.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsNumber = int.Parse(Console.ReadLine());
            int dancersNumber = int.Parse(Console.ReadLine());
            int daysNumber = int.Parse(Console.ReadLine());
            double stepsPerDay = stepsNumber / daysNumber;
            double percentStepsPerDay = Math.Ceiling((stepsPerDay / stepsNumber) * 100);
            double stepsPerDancer = percentStepsPerDay / dancersNumber;
            if (percentStepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancer:f2}% steps to be learned per day.");
            }

        }
    }
}
