using System;

namespace _08.DegreesCToDegreesF
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double f = (celsius * 9) / 5 + 32;
            Console.WriteLine("{0:f2}",f);
        }
    }
}
