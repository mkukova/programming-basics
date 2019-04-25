using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result1 = 0.0;
            int result2 = 0;
            int residue = 0;
            string type = string.Empty;
            switch (operation)
            {
                case '+':
                    result2 = number1 + number2;
                    break;
                case '-':
                    result2 = number1 - number2;
                    break;
                case '*':
                    result2 = number1 * number2;
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result1 = (double)number1 / (double)number2;
                    }

                    break;
                case '%':
                    if (number2 != 0)
                    {
                        residue = number1 % number2;
                    }

                    break;
            }

            switch (operation)
            {
                case '+':
                case '-':
                case '*':
                    if (result2 % 2 == 0)
                    {
                        type = "even";
                    }
                    else
                    {
                        type = "odd";
                    }

                    Console.WriteLine($"{number1} {operation} {number2} = {result2} - {type}");
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {(double)result1:F2}");
                    }

                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {residue}");
                    }

                    break;
            }
        }
    }
}
