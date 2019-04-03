using System;

namespace _09.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljina = int.Parse(Console.ReadLine());
            int shirina = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            int obem = daljina * shirina * h;
            double litri = obem * 0.001;
            double neobhodimilitri = litri - (litri*procent/100);
            Console.WriteLine("{0:f3}",neobhodimilitri);
        }
    }
}
