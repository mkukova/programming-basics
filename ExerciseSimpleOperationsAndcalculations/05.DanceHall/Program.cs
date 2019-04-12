using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double zalaS = l * w* 10000;
            double garderod = a * a * 10000;
            double peika = zalaS / 10;
            double freespace = zalaS - garderod - peika ;
            double dancers = freespace / 7040;
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
