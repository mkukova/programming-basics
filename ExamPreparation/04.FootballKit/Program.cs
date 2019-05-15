using System;

namespace _04.FootballKit
{
	class Program
	{
		static void Main(string[] args)
		{
			double shirtPrice = double.Parse(Console.ReadLine());
			double sumToReach = double.Parse(Console.ReadLine());
			double shortsPrice = 0.75 * shirtPrice;
			double socksPrice = 0.2 * shortsPrice;
			double shoesPrice = 2 * (shortsPrice + shirtPrice);
			double sum = shortsPrice + socksPrice + shoesPrice + shirtPrice;
			double totalSum = sum - (0.15 * sum);
			if (totalSum >= sumToReach)
			{
				Console.WriteLine($"Yes, he will earn the world-cup replica ball!");
				Console.WriteLine($"His sum is {totalSum:F2} lv.");
			}
			else if (totalSum < sumToReach)
			{
				Console.WriteLine("No, he will not earn the world-cup replica ball.");
				Console.WriteLine($"He needs {(sumToReach - totalSum):F2} lv. more.");
			}
		}
	}
}
