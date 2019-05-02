using System;

namespace _07.Salary
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double salary = double.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string webSiteName = Console.ReadLine().ToLower();
				switch (webSiteName)
				{
					case "facebook":
						salary = salary - 150;
						break;
					case "instagram":
						salary = salary - 100;
						break;
					case "reddit":
						salary = salary - 50;
						break;
				}

				if (salary <= 0)
				{
					Console.WriteLine("You have lost your salary.");
					break;
				}
			}

			int finalSalary = (int)salary;
			if (salary > 0)
			{
				Console.WriteLine(finalSalary);
			}
		}
	}
}
