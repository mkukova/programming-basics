using System;

namespace _10.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - h;
            double gamesInSofia = weekendsInSofia * (3.0 / 4);
            double gamesDuringHolidays = p * (2.0 / 3);
            double sumGames = gamesDuringHolidays + gamesInSofia + h;
            if (year == "leap")
            {
                sumGames = sumGames + 0.15 * sumGames;
            }

            Console.WriteLine(Math.Floor(sumGames));
        }
    }
}
