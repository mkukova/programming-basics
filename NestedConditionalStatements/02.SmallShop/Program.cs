using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if(city=="Sofia")
            {
                if(productName== "coffee")
                {
                    price = quantity *0.5;
                    Console.WriteLine(price);
                }
                else if(productName == "water")
                {
                    price = quantity *0.8;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity *1.2;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity *1.45;
                    Console.WriteLine(price);
                }
                else 
                {
                    price = quantity *1.6;
                    Console.WriteLine(price);
                }

            }
            else if(city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    price = quantity *0.4;
                    Console.WriteLine(price);
                }
                else if (productName == "water")
                {
                    price = quantity *0.7;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity *1.15;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity *1.3;
                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity *1.5;
                    Console.WriteLine(price);
                }
            }
            else
            {
                if (productName == "coffee")
                {
                    price = quantity *0.45;
                    Console.WriteLine(price);
                }
                else if (productName == "water")
                {
                    price = quantity *0.7;
                    Console.WriteLine(price);
                }
                else if (productName == "beer")
                {
                    price = quantity *1.10;
                    Console.WriteLine(price);
                }
                else if (productName == "sweets")
                {
                    price = quantity *1.35;
                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity *1.55;
                    Console.WriteLine(price);
                }
            }
        }
    }
}
