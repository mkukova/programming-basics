using System;

namespace _08.SameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            a = a.ToLower();
            b = b.ToLower();
            if (a == b)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine(" no");
            }
        }
    }
}
