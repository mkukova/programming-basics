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
			int counter = 6;
			while (counter > 0)
			{
				for (int k = firstNumberFirstDigit; k <= 8; k++)
				{
					for (int l = 9; l >= firstNumberSecondDigit; l--)
					{
						for (int m = secondNumberFirstDigit; m <= 8; m++)
						{
							for (int n = 9; n >= secondNumberSecondDigit; n--)
							{
								if (firstNumberFirstDigit % 2 == 0 && secondNumberFirstDigit % 2 == 0 && firstNumberSecondDigit % 2 != 0 && secondNumberSecondDigit % 2 != 0)
								{

									if (firstNumberFirstDigit == secondNumberFirstDigit && firstNumberSecondDigit == secondNumberSecondDigit)
									{
										Console.WriteLine("Cannot change the same player.");
									}
									else
									{
										Console.WriteLine($"{firstNumberFirstDigit}{firstNumberSecondDigit} - {secondNumberFirstDigit}{secondNumberSecondDigit}");
										counter--;
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
