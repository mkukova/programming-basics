using System;

namespace _01.StadiumIncome
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberSectors = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());
			double priceTicket = double.Parse(Console.ReadLine());
			double totalIncome = capacity * priceTicket;			
			double sectorIncome = totalIncome / numberSectors;
			double charityMoney = (totalIncome - (sectorIncome*0.75))/8;
			Console.WriteLine($"Total income - {totalIncome:F2} BGN");
			Console.WriteLine($"Money for charity - {charityMoney:F2} BGN");
		}
	}
}
