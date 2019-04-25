using System;

namespace _06.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0; //nechetno
            int evenSum = 0;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}
