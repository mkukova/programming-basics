using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHH = int.Parse(Console.ReadLine());
            int examMM = int.Parse(Console.ReadLine());
            int arrivalHH = int.Parse(Console.ReadLine());
            int arrivalMM = int.Parse(Console.ReadLine());
            int HH = 0;
            int MM = 0;
            int examTime = (examHH * 60) + examMM;
            int arrivalTime = (arrivalHH * 60) + arrivalMM;
            int timeDifference = examTime - arrivalTime;
            if (timeDifference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeDifference > 0)
            {
                if (timeDifference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
                else
                {
                    HH = timeDifference / 60;
                    MM = timeDifference % 60;
                    Console.WriteLine("Early");
                    if (HH == 0)
                    {
                        Console.WriteLine($"{MM} minutes before the start");
                    }
                    else
                    {
                        if (MM < 10)
                        {
                            Console.WriteLine($"{HH}:0{MM} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{HH}:{MM} hours before the start");
                        }
                    }
                }

            }
            else if (timeDifference < 0)
            {
                timeDifference = Math.Abs(timeDifference);
                HH = timeDifference / 60;
                MM = timeDifference % 60;
                Console.WriteLine("Late");
                if (HH == 0)
                {
                    Console.WriteLine($"{MM} minutes after the start");
                }
                else
                {
                    if (MM < 10)
                    {
                        Console.WriteLine($"{HH}:0{MM} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{HH}:{MM} hours after the start");
                    }
                }
            }
        }
    }
}
