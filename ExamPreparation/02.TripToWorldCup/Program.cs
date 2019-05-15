using System;

namespace _02.TripToWorldCup
{
	class Program
	{
		static void Main(string[] args)
		{
			double goTicketPrice = double.Parse(Console.ReadLine());
			double returnTicketPrice = double.Parse(Console.ReadLine());
			double gameTicketPrice = double.Parse(Console.ReadLine());
			int numberGames = int.Parse(Console.ReadLine());
			int discountPercent = int.Parse(Console.ReadLine());
			double totalSum = 6 * numberGames * gameTicketPrice;
			double totalPriceTickets = 6 * (goTicketPrice + returnTicketPrice);
			totalSum = totalSum + (totalPriceTickets - ((discountPercent * totalPriceTickets) / 100));
			Console.WriteLine($"Total sum: {totalSum:F2} lv.");
			Console.WriteLine($"Each friend has to pay {(totalSum / 6):F2} lv.");
		}
	}
}
