using System;

namespace _09.FanShop
{
	class Program
	{
		static void Main(string[] args)
		{
			int budget = int.Parse(Console.ReadLine());
			int objectsNumber = int.Parse(Console.ReadLine());
			int neededmoney = 0;
			int counter = objectsNumber;
			while (counter > 0)
			{
				string article = Console.ReadLine();
				switch (article)
				{
					case "hoodie":
						neededmoney += 30;
						break;
					case "keychain":
						neededmoney += 4;
						break;
					case "T-shirt":
						neededmoney += 20;
						break;
					case "flag":
						neededmoney += 15;
						break;
					case "sticker":
						neededmoney += 1;
						break;
					default:
						Console.WriteLine("Invalid article!");
						break;
				}

				counter--;
			}

			if (neededmoney > budget)
			{
				Console.WriteLine($"Not enough money, you need {neededmoney - budget} more lv.");
			}
			else
			{
				Console.WriteLine($"You bought {objectsNumber} items and left with {budget - neededmoney} lv.");
			}
		}
	}
}
