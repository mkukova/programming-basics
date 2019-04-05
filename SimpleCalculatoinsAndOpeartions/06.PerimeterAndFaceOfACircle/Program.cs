using System;

namespace _06.PerimeterAndFaceOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            double perimeter = 2 * r * Math.PI;
            Console.WriteLine("The area of the circle is {0:f2}",area);
            Console.WriteLine("The perimeter of the circle is {0:f2}", perimeter);
        }
    }
}
