using System;

namespace _08.GroupStage
{
	class Program
	{
		static void Main(string[] args)
		{
			string teamName = Console.ReadLine();
			int gameNumber = int.Parse(Console.ReadLine());
			int points = 0;
			int sumScoredGoals = 0;
			int sumRecievedGoals = 0;
			while (gameNumber > 0)
			{
				int scoredGoals = int.Parse(Console.ReadLine());
				int recievedGoals = int.Parse(Console.ReadLine());
				if (scoredGoals == recievedGoals)
				{
					points += 1;
				}
				else if (scoredGoals > recievedGoals)
				{
					points += 3;
				}

				sumScoredGoals += scoredGoals;
				sumRecievedGoals += recievedGoals;
				gameNumber--;
			}

			if (sumScoredGoals >= sumRecievedGoals)
			{
				Console.WriteLine($"{teamName} has finished the group phase with {points} points.");
				Console.WriteLine($"Goal difference: {sumScoredGoals - sumRecievedGoals}.");
			}
			else
			{
				Console.WriteLine($"{teamName} has been eliminated from the group phase.");
				Console.WriteLine($"Goal difference: {sumScoredGoals - sumRecievedGoals}.");
			}
		}
	}
}
