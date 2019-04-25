using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int coin = 0;
            double lv = Math.Floor(money);
            double cent = Math.Floor(money * 100 - lv * 100);
            while (lv > 0)
            {
                if (lv >= 2)
                {
                    coin++;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    coin++;
                    lv -= 1;
                }
            }

            while (cent > 0)
            {
                if (cent >= 50)
                {
                    coin++;
                    cent -= 50;
                }
                else if (cent >= 20)
                {
                    coin++;
                    cent -= 20;
                }
                else if (cent >= 10)
                {
                    coin++;
                    cent -= 10;
                }
                else if (cent >= 5)
                {
                    coin++;
                    cent -= 5;
                }
                else if (cent >= 2)
                {
                    coin++;
                    cent -= 2;
                }
                else if (cent >= 1)
                {
                    coin++;
                    cent -= 1;
                }
            }

            Console.WriteLine(coin);
        }
    }
}
