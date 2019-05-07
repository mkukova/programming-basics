using System;

namespace _03.Coding
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();
			int lenghtNumber = number.Length;

			for (int i = lenghtNumber - 1; i >= 0; i--)
			{
				int currentDigit = int.Parse(number[i].ToString());
				if (currentDigit == 0)
				{
					Console.WriteLine("ZERO");
					continue;
				}


				for (int line = 1; line <= currentDigit; line++)
				{

					Console.Write($"{(char)(currentDigit + 33)}");
				}

				Console.WriteLine();
			}
		}
	}
}
