﻿using System;

namespace Numbers1_N_WithStep3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i += 3)
			{
				Console.WriteLine(i);
			}
		}
	}
}
