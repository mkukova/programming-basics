using System;

namespace _10.GameInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			string teamName = Console.ReadLine();
			int numberPlayedGames = int.Parse(Console.ReadLine());
			int counter = numberPlayedGames;
			int totalTime = 0;
			int counterAdditionalTime = 0;
			int counterPenalties = 0;
			while (counter > 0)
			{
				int time = int.Parse(Console.ReadLine());
				totalTime += time;
				if (time > 120)
				{
					counterPenalties++;
				}
				else if (time > 90)
				{
					counterAdditionalTime++;
				}

				counter--;
			}

			Console.WriteLine($"{teamName} has played {totalTime} minutes. Average minutes per game: {((double)totalTime / (double)numberPlayedGames):F2}");
			Console.WriteLine($"Games with penalties: {counterPenalties}");
			Console.WriteLine($"Games with additional time: {counterAdditionalTime}");

		}
	}
}
