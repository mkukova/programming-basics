using System;

namespace _10.SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberN = int.Parse(Console.ReadLine());
			bool number = false;
			for (int i = 1111; i <= 9999; i++)
			{
				int n = i;
				while (n > 0)
				{
					if (n % 10 == 0)
					{
						number = false;
						break;
					}
					else if (numberN % (n % 10) == 0)
					{
						number = true;
					}
					else if (numberN % (n % 10) != 0)
					{
						number = false;
						break;
					}

					n = n / 10;
				}

				if (number)
				{
					Console.Write($"{i} ");
				}

				number = false;
			}
		}
	}
}
