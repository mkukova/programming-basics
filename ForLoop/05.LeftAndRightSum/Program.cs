using System;

namespace _05.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int diff = 0;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = n; i < 2 * n; i++)
            {
                number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                diff = leftSum - rightSum;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
        }
    }
}
