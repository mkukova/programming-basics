using System;

namespace _05.Building
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberFloors = int.Parse(Console.ReadLine());
			int numberRooms = int.Parse(Console.ReadLine());
			for (int floor = numberFloors; floor >= 1; floor--)
			{
				for (int room = 0; room < numberRooms; room++)
				{
					if (floor == numberFloors)
					{
						Console.Write($"L{floor}{room} ");
					}
					else if (floor % 2 == 0)
					{
						Console.Write($"O{floor}{room} ");
					}
					else
					{
						Console.Write($"A{floor}{room} ");
					}
				}

				Console.WriteLine();
			}
		}
	}
}
