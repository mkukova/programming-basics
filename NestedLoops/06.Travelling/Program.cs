using System;

namespace _06.Travelling
{
	class Program
	{
		static void Main(string[] args)
		{
			string destination = Console.ReadLine();
			while (destination != "End")
			{
				double neededMoney = double.Parse(Console.ReadLine());
				double savedMoney = double.Parse(Console.ReadLine());
				while (savedMoney < neededMoney)
				{
					double money = double.Parse(Console.ReadLine());
					savedMoney += money;
				}

				savedMoney = 0;
				Console.WriteLine($"Going to {destination}!");
				destination = Console.ReadLine();
			}
		}
	}
}
