using System;

namespace _10.SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberN = int.Parse(Console.ReadLine());
			/*		for (int num1 = 1; num1 <= 9; num1++)
					{
						for (int num2 = 1; num1 <= 9; num2++)
						{
							for (int num3 = 1; num3 <= 9; num3++)
							{
								for (int num4 = 1; num4 <= 9; num4++)
								{
									if (numberN % num1 == 0 && numberN % num2 == 0 && numberN % num3 == 0 && numberN % num4 == 0)
									{
										Console.Write($"{num1}{num2}{num3}{num4} ");
									}
								}
							}
						}
					}
					*/
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
