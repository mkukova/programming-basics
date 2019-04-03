using System;

namespace _03.FaceOfRectangleInThePlane
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            double p = (2 * (a + b));
            double s = a * b;
            Console.WriteLine("{0:f2}",s);
            Console.WriteLine("{0:f2}", p);
        }
    }
}
