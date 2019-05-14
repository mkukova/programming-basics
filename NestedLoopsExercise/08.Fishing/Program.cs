using System;

namespace _08.Fishing
{
	class Program
	{
		static void Main(string[] args)
		{
			int dailyQuota = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			double profit = 0;
			double loss = 0;
			double price = 0;
			int counter = 0;
			int numberFishes = 0;
			int n = dailyQuota;
			while (command != "Stop")
			{
				price = 0;
				double kilo = double.Parse(Console.ReadLine());
				for (int i = 0; i < command.Length; i++)
				{
					char currentLetter = command[i];
					int currentLetterToNum = (int)currentLetter;
					price += currentLetterToNum;
				}

				price = (price / kilo) ;
				counter++;
				numberFishes++;
				if (counter == 3)
				{
					profit += price;
					counter = 0;
				}
				else
				{
					loss += price;
				}

				n--;
				if (n == 0)
				{
					break;
				}

				command = Console.ReadLine();
			}

			double money = profit - loss;
			if (numberFishes == dailyQuota)
			{
				Console.WriteLine($"Lyubo fulfilled the quota!");
			}

			if (profit > loss)
			{
				Console.WriteLine($"Lyubo's profit from {numberFishes} fishes is {money:F2} leva.");
			}
			else if(loss> profit)
			{
				Console.WriteLine($"Lyubo lost {(loss - profit):F2} leva today.");
			}
		}
	}
}
