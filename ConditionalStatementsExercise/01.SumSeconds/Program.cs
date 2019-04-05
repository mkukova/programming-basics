using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int time = first + second + third;
            int minutes = time / 60;
            int seconds = time % 60;
            if(seconds<10)
            {
                Console.Write("{0}:0{1}", minutes, seconds);
            }
            else { Console.WriteLine("{0}:{1}", minutes, seconds); }
        }
    }
}
