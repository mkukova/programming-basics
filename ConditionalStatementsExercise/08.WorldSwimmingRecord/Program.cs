using System;

namespace _08.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double leght = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            double neededtime = leght * timePerMeter;
            double delay = Math.Floor(leght / 15.0);
            double bonustime = delay * 12.5;
            double totaltime = neededtime + bonustime;
            if (totaltime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totaltime:f2} seconds.");
            }
            else
            {
                double seconds = totaltime - worldRecord;
                Console.WriteLine($"No, he failed! He was {seconds:f2} seconds slower.");
            }
        }
    }
}
