using System;

namespace _07.GuessThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "s3cr3t!P@ssw0rd";
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine(" Wrong password!");
            }

        }
    }
}
