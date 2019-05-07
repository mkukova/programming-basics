using System;

namespace _01.Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int num4 = int.Parse(Console.ReadLine());
			for (int firstLineFirstNumber = num1; firstLineFirstNumber <= num2; firstLineFirstNumber++)
			{
				for (int firstLineSecondNumber = num1; firstLineSecondNumber <= num2; firstLineSecondNumber++)
				{
					for (int secondLineFirstNumber = num3; secondLineFirstNumber <= num4; secondLineFirstNumber++)
					{
						for (int secondLineSecondNumber = num3; secondLineSecondNumber <= num4; secondLineSecondNumber++)
						{
							if ((firstLineFirstNumber + secondLineSecondNumber == firstLineSecondNumber + secondLineFirstNumber) && (firstLineFirstNumber != firstLineSecondNumber) && (secondLineFirstNumber != secondLineSecondNumber))
							{
								Console.WriteLine($"{firstLineFirstNumber}{firstLineSecondNumber}");
								Console.WriteLine($"{secondLineFirstNumber}{secondLineSecondNumber}");
								Console.WriteLine();
							}
						}
					}
				}
			}
		}
	}
}
