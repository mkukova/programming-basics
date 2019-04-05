using System;

namespace _11.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = double.Parse(Console.ReadLine());
            int pazeli = int.Parse(Console.ReadLine());
            int kukli = int.Parse(Console.ReadLine());
            int meche = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int kamion = int.Parse(Console.ReadLine());
            double otstapka = 0.0;
            double sum = pazeli * 2.6 + kukli * 3 + meche * 4.10 + minion * 8.20 + kamion * 2;
            double broi = pazeli + meche + minion + kukli + kamion;
            if (broi >= 50) { otstapka = 0.25 * sum; }
            else { otstapka = 0.0; }
            double finalsum = sum - otstapka;
            double naem = finalsum * 0.1;
            double pechalba = finalsum - naem;
            double ostatak = 0.0;
            if (cena <= pechalba)
            {
                ostatak = pechalba - cena;
                Console.WriteLine($"Yes! {ostatak:f2} lv left.");
            }
            else
            {
                ostatak = cena - pechalba;
                Console.WriteLine($"Not enough money! {ostatak:f2} lv needed.");
            }
        }
    }
}