using System;

namespace _03.BeerAndChips
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			double budget = double.Parse(Console.ReadLine());
			int numberBeers = int.Parse(Console.ReadLine());
			int numberChips = int.Parse(Console.ReadLine());
			double totalSum = numberBeers * 1.2;
			double chipsPrice = (45 * totalSum) / 100;
			chipsPrice = Math.Ceiling(numberChips * chipsPrice);
			totalSum += chipsPrice;
			if (budget >= totalSum)
			{
				Console.WriteLine($"{name} bought a snack and has {(budget - totalSum):F2} leva left.");
			}
			else
			{
				Console.WriteLine($"{name} needs {(totalSum - budget):F2} more leva!");
			}
		}
	}
}
