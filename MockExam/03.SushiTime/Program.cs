using System;

namespace _03.SushiTime
{
	class Program
	{
		static void Main(string[] args)
		{
			string sushi = Console.ReadLine();
			string restaurant = Console.ReadLine();
			int numberPortions = int.Parse(Console.ReadLine());
			char symbol = char.Parse(Console.ReadLine());
			double prize = 0;
			bool isValid = true;
			switch (restaurant)
			{
				case "Sushi Zone":
					switch (sushi)
					{
						case "sashimi":
							prize = numberPortions * 4.99;
							break;
						case "maki":
							prize = numberPortions * 5.29;
							break;
						case "uramaki":
							prize = numberPortions * 5.99;
							break;
						case "temaki":
							prize = numberPortions * 4.29;
							break;
						default:
							Console.WriteLine("Invalid product!");
							break;
					}

					break;
				case "Sushi Time":
					switch (sushi)
					{
						case "sashimi":
							prize = numberPortions * 5.49;
							break;
						case "maki":
							prize = numberPortions * 4.69;
							break;
						case "uramaki":
							prize = numberPortions * 4.49;
							break;
						case "temaki":
							prize = numberPortions * 5.19;
							break;
						default:
							Console.WriteLine("Invalid product!");
							break;
					}

					break;
				case "Sushi Bar":
					switch (sushi)
					{
						case "sashimi":
							prize = numberPortions * 5.25;
							break;
						case "maki":
							prize = numberPortions * 5.55;
							break;
						case "uramaki":
							prize = numberPortions * 6.25;
							break;
						case "temaki":
							prize = numberPortions * 4.75;
							break;
						default:
							Console.WriteLine("Invalid product!");
							break;
					}

					break;
				case "Asian Pub":
					switch (sushi)
					{
						case "sashimi":
							prize = numberPortions * 4.5;
							break;
						case "maki":
							prize = numberPortions * 4.8;
							break;
						case "uramaki":
							prize = numberPortions * 5.5;
							break;
						case "temaki":
							prize = numberPortions * 5.5;
							break;
						default:
							Console.WriteLine("Invalid product!");
							break;
					}

					break;
				default:
					Console.WriteLine($"{restaurant} is invalid restaurant!");
					isValid = false;
					break;
			}

			if (isValid)
			{
				if (symbol == 'Y')
				{
					prize += 0.2 * prize;
				}

				Console.WriteLine($"Total price: {Math.Ceiling(prize)} lv.");
			}

		}
	}
}
