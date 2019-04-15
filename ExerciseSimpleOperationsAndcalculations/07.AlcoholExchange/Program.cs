using System;

namespace _07.AlcoholExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaYiski = double.Parse(Console.ReadLine());
            double biraL = double.Parse(Console.ReadLine());
            double vinoL = double.Parse(Console.ReadLine());
            double rakiqL = double.Parse(Console.ReadLine());
            double yiskiL = double.Parse(Console.ReadLine());
            double cenaRakiq = cenaYiski / 2;
            double cenaBira = cenaRakiq - (0.8 * cenaRakiq);
            double cenaVino = cenaRakiq - (0.4 * cenaRakiq);
            double sumrakiq = cenaRakiq * rakiqL;
            double sumvino = cenaVino * vinoL;
            double sumyiski = cenaYiski * yiskiL;
            double sumbira = cenaBira * biraL;
            double sum = sumbira + sumrakiq + sumvino + sumyiski;
            Console.WriteLine($"{sum:f2} lv");


        }
    }
}
