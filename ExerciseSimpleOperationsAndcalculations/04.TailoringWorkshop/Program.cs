using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int masi = int.Parse(Console.ReadLine());
            double daljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double pokrivka = masi * (daljina + 2 * 0.30) * (shirina + 2 * 0.30);
            double kare = masi * (daljina / 2) * (daljina / 2);
            double cenaDolar = pokrivka * 7 + kare * 9;
            double cenaLeva = cenaDolar * 1.85;
            Console.WriteLine("{0:F2}",cenaDolar + " USD");
            Console.WriteLine($"{cenaLeva:F2} BGN");
        }
    }
}
