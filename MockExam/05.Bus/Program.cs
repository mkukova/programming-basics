using System;

namespace _05.Bus
{
	class Program
	{
		static void Main(string[] args)
		{
			int passengers = int.Parse(Console.ReadLine());
			int stops = int.Parse(Console.ReadLine());
			int counterStops = 0;
			int totalPassengers = passengers;
			while (stops > 0)
			{
				int landedPassengers = int.Parse(Console.ReadLine());
				int boardedPassengers = int.Parse(Console.ReadLine());
				counterStops++;

				if (counterStops % 2 == 0)
				{
					landedPassengers += 2;
				}
				else
				{
					boardedPassengers += 2;
				}

				totalPassengers = totalPassengers - landedPassengers + boardedPassengers;
				stops--;
			}

			Console.WriteLine($"The final number of passengers is : {totalPassengers}");
		}
	}
}
