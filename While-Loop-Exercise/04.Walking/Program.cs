using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            string command = string.Empty;
            int stepsDiff = 0;
            while (steps < 10000)
            {
                command = Console.ReadLine();
                if (command == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        stepsDiff = 10000 - steps;
                        Console.WriteLine($"{stepsDiff} more steps to reach goal.");

                    }

                    break;
                }
                else
                {
                    steps += int.Parse(command);
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                }
            }
        }
    }
}
