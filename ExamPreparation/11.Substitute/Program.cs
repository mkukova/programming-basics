using System;

namespace _11.Substitute
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumberFirstDigit = int.Parse(Console.ReadLine());
			int firstNumberSecondDigit = int.Parse(Console.ReadLine());
			int secondNumberFirstDigit = int.Parse(Console.ReadLine());
			int secondNumberSecondDigit = int.Parse(Console.ReadLine());
			int counter = 0;

			for (int k = firstNumberFirstDigit; k <= 8; k++)
			{
				for (int l = 9; l >= firstNumberSecondDigit; l--)
				{
					for (int m = secondNumberFirstDigit; m <= 8; m++)
					{
						for (int n = 9; n >= secondNumberSecondDigit; n--)
						{
							if (k % 2 == 0 && m % 2 == 0 && l % 2 != 0 && n % 2 != 0)
							{

								if (k == m && l == n)
								{
									Console.WriteLine("Cannot change the same player.");
								}
								else
								{
									Console.WriteLine($"{k}{l} - {m}{n}");
									counter++;

									if (counter == 6)
									{
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}
}

