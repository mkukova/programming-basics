using System;

namespace _05.EqualSumsLeftRightPosition
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			for (int i = firstNumber; i <= secondNumber; i++)
			{
				string currentNumber = i.ToString();
				int rightSum = 0;
				int leftSum = 0;
				for (int j = 0; j < (currentNumber.Length / 2); j++)
				{
					int currentDigit = int.Parse(currentNumber[j].ToString());
					leftSum += currentDigit;
				}
				for (int j = ((currentNumber.Length / 2) + 1); j < currentNumber.Length; j++)
				{
					int currentDigit = int.Parse(currentNumber[j].ToString());
					rightSum += currentDigit;
				}

				if (rightSum == leftSum)
				{
					Console.Write($"{i} ");
				}
				else
				{
					int currentDigit = int.Parse(currentNumber[2].ToString());
					if (rightSum < leftSum)
					{
						rightSum += currentDigit;
					}
					else
					{
						leftSum += currentDigit;
					}
					if (rightSum == leftSum)
					{
						Console.Write($"{i} ");
					}
				}
			}
		}
	}
}

