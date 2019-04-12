using System;

namespace _02.JoiningTextAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string town = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}!", firstName, lastName, years, town);
        }
    }
}
