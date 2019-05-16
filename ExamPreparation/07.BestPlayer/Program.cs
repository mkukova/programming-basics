using System;

namespace _07.BestPlayer
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			int goals = 0;
			string bestplayer = string.Empty;
			int maxGoals = int.MinValue;
			while (command != "END")
			{
				goals = int.Parse(Console.ReadLine());
				if (goals > maxGoals)
				{
					maxGoals = goals;
					bestplayer = command;
				}

				if (goals >= 10)
				{
					break;
				}
				else
				{
					command = Console.ReadLine();
				}
			}

			Console.WriteLine($"{bestplayer} is the best player!");
			if (maxGoals >= 3)
			{
				Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
			}
			else
			{
				Console.WriteLine($"He has scored {maxGoals} goals.");
			}
		}
	}
}
