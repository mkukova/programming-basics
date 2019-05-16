using System;

namespace _06.FootballSouvenirs
{
	class Program
	{
		static void Main(string[] args)
		{
			string team = Console.ReadLine();
			string souvenir = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double totalSum = 0;
			bool correctInput = true;
			switch (team)
			{
				case "Argentina":
					switch (souvenir)
					{
						case "flags":
							totalSum = quantity * 3.25;
							break;
						case "caps":
							totalSum = quantity * 7.20;
							break;
						case "posters":
							totalSum = quantity * 5.10;
							break;
						case "stickers":
							totalSum = quantity * 1.25;
							break;
						default:
							Console.WriteLine("Invalid stock!");
							correctInput = false;
							break;
					}

					break;
				case "Brazil":
					switch (souvenir)
					{
						case "flags":
							totalSum = quantity * 4.20;
							break;
						case "caps":
							totalSum = quantity * 8.50;
							break;
						case "posters":
							totalSum = quantity * 5.35;
							break;
						case "stickers":
							totalSum = quantity * 1.20;
							break;
						default:
							Console.WriteLine("Invalid stock!");
							correctInput = false;
							break;
					}

					break;
				case "Croatia":
					switch (souvenir)
					{
						case "flags":
							totalSum = quantity * 2.75;
							break;
						case "caps":
							totalSum = quantity * 6.90;
							break;
						case "posters":
							totalSum = quantity * 4.95;
							break;
						case "stickers":
							totalSum = quantity * 1.10;
							break;
						default:
							Console.WriteLine("Invalid stock!");
							correctInput = false;
							break;
					}

					break;
				case "Denmark":
					switch (souvenir)
					{
						case "flags":
							totalSum = quantity * 3.10;
							break;
						case "caps":
							totalSum = quantity * 6.50;
							break;
						case "posters":
							totalSum = quantity * 4.80;
							break;
						case "stickers":
							totalSum = quantity * 0.90;
							break;
						default:
							Console.WriteLine("Invalid stock!");
							correctInput = false;
							break;
					}

					break;
				default:
					Console.WriteLine("Invalid country!");
					correctInput = false;
					break;
			}

			if (correctInput)
			{
				Console.WriteLine($"Pepi bought {quantity} {souvenir} of {team} for {totalSum:F2} lv.");
			}

		}
	}
}
