using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBadGrades = int.Parse(Console.ReadLine());
            int countBadGrades = 0;
            int countGoodGrades = 0;
            double sumGrades = 0.0;
            string lastProblem = string.Empty;
            double averageGrade = 0.0;
            int totalProblems = 0;
            while (countBadGrades < numberBadGrades)
            {
                string nameOfExercise = Console.ReadLine();
                if (nameOfExercise == "Enough")
                {
                    Console.WriteLine($"Average score: {averageGrade:F2}");
                    Console.WriteLine($"Number of problems: {totalProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                if (grade <= 4.00)
                {
                    countBadGrades++;
                }
                else
                {
                    countGoodGrades++;
                }

                lastProblem = nameOfExercise;
                totalProblems = countGoodGrades + countBadGrades;
                averageGrade = sumGrades / totalProblems;
            }

            if (countBadGrades == numberBadGrades)
            {
                Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
            }
        }
    }
}
