using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int strathour = int.Parse(Console.ReadLine());
            int stratminutes = int.Parse(Console.ReadLine());
            int newtime = 15 + stratminutes + strathour * 60;
            int finalhour = newtime / 60;
            int finalminutes = newtime % 60;
            if (finalhour >= 24)
            {
                finalhour = finalhour - 24;
            }
            if (finalminutes < 10)
            {
                Console.WriteLine($"{finalhour}:0{finalminutes}");
            }
            else { Console.WriteLine($"{finalhour}:{finalminutes}"); }
        }
    }
}
