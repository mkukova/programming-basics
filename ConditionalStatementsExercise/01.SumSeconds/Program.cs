using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int timefirst = int.Parse(Console.ReadLine());
            int timesecond = int.Parse(Console.ReadLine());
            int timethird = int.Parse(Console.ReadLine());
            int totaltime = timefirst + timesecond + timethird;
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;
            if (seconds < 10)
            {
                Console.Write("{0}:0{1}", minutes, seconds);
            }
            else { Console.WriteLine("{0}:{1}", minutes, seconds); }
        }
    }
}
