using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            string action = string.Empty;
            double money = 0.0;
            int countSpendTimes = 0;
            int countDays = 0;
            while (countSpendTimes < 5 && moneyOnHand < moneyNeededForVacation)
            {
                action = Console.ReadLine().ToLower();
                money = double.Parse(Console.ReadLine());
                switch (action)
                {
                    case "save":
                        moneyOnHand = moneyOnHand + money;
                        countDays++;
                        countSpendTimes = 0;
                        break;
                    case "spend":
                        countSpendTimes++;
                        countDays++;
                        moneyOnHand = moneyOnHand - money;
                        if (moneyOnHand < 0)
                        {
                            moneyOnHand = 0.0;
                        }

                        break;
                }
            }

            if (countSpendTimes == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
