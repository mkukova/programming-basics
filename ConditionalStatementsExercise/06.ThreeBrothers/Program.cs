using System;

namespace _06.ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstbrother = double.Parse(Console.ReadLine());
            double secondbrother = double.Parse(Console.ReadLine());
            double thirdbrother = double.Parse(Console.ReadLine());
            double fathertime = double.Parse(Console.ReadLine());
            double neededtime = 1 / ((1 / firstbrother) + (1 / secondbrother) + (1 / thirdbrother));
            double timewithrest = neededtime * 1.15;
            double lefttime = fathertime - timewithrest;
            Console.WriteLine($"Cleaning time: {timewithrest:f2}");
            if (lefttime >= 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {lefttime:f0} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(lefttime)):f0} hours.");
            }
        }
    }
}
