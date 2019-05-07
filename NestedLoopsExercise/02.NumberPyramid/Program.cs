using System;

namespace _02.NumberPyramid
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int currentValue = 1;
			bool Stop = false;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					if (currentValue > n)
					{
						Stop = true;
						break;
					}
					else
					{
						Console.Write($"{currentValue} ");
						currentValue++;
					}
				}

				if (Stop)
				{
					break;
				}
				else
				{
					Console.WriteLine();
				}
			}
		}
	}
}
