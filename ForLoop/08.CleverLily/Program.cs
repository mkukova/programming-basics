using System;

namespace _08.CleverLily
{
	class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			double washingMachinePriece = double.Parse(Console.ReadLine());
			int toyPrice = int.Parse(Console.ReadLine());
			int moneyYears = 0;
			int toyYears = 0;
			double money = 0.0;
			double diff = 0;
			double takenMoney = 0;
			for (int i = 1; i <= age; i++)
			{
				if (i % 2 == 0)
				{
					moneyYears++;
					takenMoney++;
				}
				else
				{
					toyYears++;
				}
			}

			for (int i = 1; i <= moneyYears; i++)
			{
				money += 10 * i;
			}

			money = money + (toyYears * toyPrice);
			money = money - takenMoney;
			diff = washingMachinePriece - money;

			if (money >= washingMachinePriece)
			{
				Console.WriteLine($"Yes! {Math.Abs(diff):F2}");
			}
			else
			{
				Console.WriteLine($"No! {Math.Abs(diff):F2}");
			}
		}
	}
}
