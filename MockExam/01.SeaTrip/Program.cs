using System;

namespace _01.SeaTrip
{
	class Program
	{
		static void Main(string[] args)
		{
			double moneyForFood = double.Parse(Console.ReadLine());
			double moneyForSouvenirs = double.Parse(Console.ReadLine());
			double moneyForHotel = double.Parse(Console.ReadLine());
			double discount = 0.1 * moneyForHotel + 0.15 * moneyForHotel + 0.2 * moneyForHotel;
			double totalMoney = (420.0 / 100.0 * 7.0) * 1.85;
			totalMoney += 3 * (moneyForFood + moneyForSouvenirs + moneyForHotel);
			totalMoney -= discount;
			Console.WriteLine($"Money needed: {totalMoney:F2}");
		}
	}
}
