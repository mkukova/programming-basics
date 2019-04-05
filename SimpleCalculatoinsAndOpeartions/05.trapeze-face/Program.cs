using System;

namespace _05.trapeze_face
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double square = (a + b)*h/ 2;
            Console.WriteLine("The square of the trapeze is " + square);
        }
    }
}
