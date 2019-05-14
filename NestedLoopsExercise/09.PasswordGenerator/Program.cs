using System;

namespace _09.PasswordGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());
			for (int symbol1 = 1; symbol1 <= number1; symbol1++)
			{
				for (int symbol2 = 1; symbol2 <= number1; symbol2++)
				{
					for (char symbol3 = 'a'; symbol3 < 'a' + number2; symbol3++)
					{
						for (char symbol4 = 'a'; symbol4 < 'a' + number2; symbol4++)
						{
							for (int symbol5 = Math.Max(symbol1, symbol2) + 1; symbol5 <= number1; symbol5++)
							{
								if (symbol5 > symbol1 && symbol5 > symbol1)
								{
									Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
								}
							}
						}
					}
				}
			}
		}
	}
}
