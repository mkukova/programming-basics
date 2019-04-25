using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int leght = int.Parse(Console.ReadLine());
            int face = width * leght;
            int f = face;
            int numberPiecesTaken = 0;
            int facePiecesTaken = 0;
            int piecesDiff = 0;
            while (face >= 0)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "stop")
                {
                    piecesDiff = (f) - numberPiecesTaken;
                    Console.WriteLine($"{piecesDiff} pieces are left.");
                    break;
                }
                else
                {
                    facePiecesTaken = int.Parse(command);
                    numberPiecesTaken = facePiecesTaken + numberPiecesTaken;
                    face = face - facePiecesTaken;
                }
            }

            if (face < 0)
            {
                piecesDiff = numberPiecesTaken - (f);
                Console.WriteLine($"No more cake left! You need {piecesDiff} pieces more.");
            }
        }
    }
}
