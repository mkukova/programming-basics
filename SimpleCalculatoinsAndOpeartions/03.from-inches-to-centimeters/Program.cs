﻿using System;

namespace _03.from_inches_to_centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine("{0:f2}", centimeters);
        }
    }
}
