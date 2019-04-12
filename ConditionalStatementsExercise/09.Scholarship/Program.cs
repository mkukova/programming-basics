using System;

namespace _09.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(0.35 * minSalary);
            double successScholarship = Math.Floor(success * 25);
            if (success >= 5.50 && successScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {successScholarship} BGN");
            }
            else if (income < minSalary && success > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
