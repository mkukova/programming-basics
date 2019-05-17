using System;

namespace _02.Spaceship
{
	class Program
	{
		static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine());
			double lenght = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			double averageHeightAstronauts = double.Parse(Console.ReadLine());
			double volumeSpacecraft = width * lenght * height;
			double volumeRoom = (averageHeightAstronauts + 0.4) * 2 * 2;
			double people = Math.Floor(volumeSpacecraft / volumeRoom);

			if (people <= 3)
			{
				Console.WriteLine("The spacecraft is too small.");
			}
			else if (people > 3 && people <= 10)
			{
				Console.WriteLine($"The spacecraft holds {people} astronauts.");
			}
			else
			{
				Console.WriteLine("The spacecraft is too big.");
			}
		}
	}
}
