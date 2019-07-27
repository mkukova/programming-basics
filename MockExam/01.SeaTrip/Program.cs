using System;

namespace _01.SeaTrip
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int newHours = hours;
			int newMinutes = minutes + 30;
			while(newMinutes>60 && newHours>23)
			{
				newMinutes -= 60;
				newHours += 1;
				if (newHours > 23)
				{
					newHours -= 23;
				}
			}
			
			if(newMinutes<10)
			{
				Console.WriteLine($"{newHours}:0{newMinutes}");
			}
			else
			{
				Console.WriteLine($"{newHours}:{newMinutes}");
			}
			
		}
	}
}
