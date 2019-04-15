using System;

namespace _08.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int DaysTostay = int.Parse(Console.ReadLine());
            string roomKind = Console.ReadLine().ToLower();
            string rating = Console.ReadLine().ToLower();
            double cost = 0;
            int overnights = DaysTostay - 1;
            if (DaysTostay < 10)
            {
                if (roomKind == "room for one person")
                {
                    cost = overnights * 18.0;
                }
                else if (roomKind == "apartment")
                {
                    cost = overnights * 25.0;
                    cost = cost - (cost * 0.3);
                }
                else if (roomKind == "president apartment")
                {
                    cost = overnights * 35.0;
                    cost = cost - (cost * 0.1);
                }
            }
            else if (DaysTostay > 10 && DaysTostay < 15)
            {
                if (roomKind == "room for one person")
                {
                    cost = overnights * 18.0;
                }
                else if (roomKind == "apartment")
                {
                    cost = overnights * 25.0;
                    cost = cost - (cost * 0.35);
                }
                else if (roomKind == "president apartment")
                {
                    cost = overnights * 35.0;
                    cost = cost - (cost * 0.15);
                }
            }
            else if (DaysTostay > 15)
            {
                if (roomKind == "room for one person")
                {
                    cost = overnights * 18.0;
                }
                else if (roomKind == "apartment")
                {
                    cost = overnights * 25.0;
                    cost = cost - (cost * 0.5);
                }
                else if (roomKind == "president apartment")
                {
                    cost = overnights * 35.0;
                    cost = cost - (cost * 0.2);
                }
            }
            if (rating == "positive")
            {
                cost = cost + (cost * 0.25);
            }
            else if (rating == "negative")
            {
                cost = cost - (cost * 0.1);
            }
            Console.WriteLine($"{cost:F2}");
        }
    }
}
