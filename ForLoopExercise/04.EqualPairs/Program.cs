using System;

namespace _04.EqualPairs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double sum = 0;
			double previousSum = 0;
			double diff = 0;
			double previousDiff = 0;
			double maxDiff = 0;
			for (int i = 0; i < n; i++)
			{
				double num1 = double.Parse(Console.ReadLine());
				double num2 = double.Parse(Console.ReadLine());
				sum = num1 + num2;
				if (i == 0)
				{
					diff = 0;
				}
				else
				{
					diff =Math.Abs(sum - previousSum);
					if (diff > previousDiff)
					{
						maxDiff = diff;
					}
				}
				
				previousSum = sum;				
			}

			switch(maxDiff)
			{
				case 0:
					Console.WriteLine($"Yes, value={sum}");
					break;
				default:
					Console.WriteLine($"No, maxdiff={maxDiff}");
					break;
			}
		}
	}
}
