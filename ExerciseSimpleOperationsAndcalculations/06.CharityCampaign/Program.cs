using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double sumcakes = cakes * 45;
            double sumwaffles = waffles * 5.8;
            double sumpancakes = pancakes * 3.2;
            double sum = (sumcakes + sumpancakes + sumwaffles)*cooks;
            double obshtasuma = sum * days;
            double result = obshtasuma - (obshtasuma / 8);
            Console.WriteLine($"{result:f2}");

        }
    }
}
