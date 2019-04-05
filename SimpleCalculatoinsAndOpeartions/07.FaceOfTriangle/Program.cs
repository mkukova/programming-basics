using System;

namespace _07.FaceOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double face = a * h / 2;
            Console.WriteLine("The face of the triangle is {0:f2}",face);
        }
    }
}
