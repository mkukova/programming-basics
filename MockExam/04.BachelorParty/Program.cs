using System;

namespace _04.BachelorParty
{
	class Program
	{
		static void Main(string[] args)
		{
			int moneyForSinger = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			int sum = 0;
			int guests = 0;
			while (command != "The restaurant is full")
			{
				int people = int.Parse(command);
				if (people < 5)
				{
					sum += people * 100;
				}
				else if (people >= 5)
				{
					sum += people * 70;
				}

				guests += people;
				command = Console.ReadLine();
			}

			if (sum >= moneyForSinger)
			{
				Console.WriteLine($"You have {guests} guests and {(sum - moneyForSinger)} leva left.");
			}
			else
			{
				Console.WriteLine($"You have {guests} guests and {sum} leva income, but no singer.");
			}
		}
	}
}
