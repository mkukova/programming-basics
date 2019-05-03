using System;

namespace _08.CookieFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			int batchCount = int.Parse(Console.ReadLine());
			for (int i = 1; i <= batchCount; i++)
			{
				bool flour = false;
				bool eggs = false;
				bool sugar = false;
				string productName = Console.ReadLine();

				while (true)
				{
					if (productName == "sugar")
					{
						sugar = true;
					}
					else if (productName == "eggs")
					{
						eggs = true;
					}
					else if (productName == "flour")
					{
						flour = true;
					}
					else if (productName == "Bake!")
					{
						if (sugar && eggs && flour)
						{
							Console.WriteLine($"Baking batch number {i}...");
							break;
						}
						else
						{
							Console.WriteLine("The batter should contain flour, eggs and sugar!");
						}
					}

					productName = Console.ReadLine();
				}
			}
		}
	}
}


