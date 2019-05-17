using System;

namespace _06.MultiplyTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int firstDigit = number % 10;
			int secondDigit = (number / 10) % 10;
			int thirdDigit = number / 100;
			for (int a = 1; a <= firstDigit; a++)
			{
				for (int b = 1; b <= secondDigit; b++)
				{
					for (int c = 1; c <= thirdDigit; c++)
					{
						Console.WriteLine($"{a} * {b} * {c} = {a * b * c};");
					}
				}
			}
		}
	}
}
