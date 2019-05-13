using System;

namespace _07.TrainTheTrainers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			double finalMark = 0;
			int counter = 0;
			while (command != "Finish")
			{
				double sum = 0;
				for (int i = 0; i < n; i++)
				{
					double mark = double.Parse(Console.ReadLine());
					sum += mark;
					finalMark += mark;
					counter++;
				}
				Console.WriteLine($"{command} - {(sum / n):F2}.");
				command = Console.ReadLine();
			}

			finalMark = finalMark / counter;
			Console.WriteLine($"Student's final assessment is {finalMark:F2}.");
		}
	}
}
