using System;

namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*--------Welcome To Snakes and Ladder Game--------*");
            Console.WriteLine();
            Console.WriteLine("Press key to start the Game.");
            Console.ReadKey();
            int Position = 99;
            bool PlayGame = true;
            while (PlayGame)
            {
                Position = Play(Position);
                if (Position <= 0) 
                {
                    Console.WriteLine("You went under 0: ");
                    Console.WriteLine();
                    Position= 0;
                }
                else if(Position == 100)
                {
                    break;
                }
            }
            Console.WriteLine("*---------------------*");
            Console.WriteLine("You Won");
            Console.WriteLine("*---------------------*");

        }

        public static int Play(int Position)
        {
            Console.WriteLine();
            Console.WriteLine("You are at position: " + Position);
            Console.WriteLine("Press a key to Roll.");
            Console.ReadKey();
            int Roll = RollDice();
            Console.WriteLine("You have Rolled: " + Roll);
            Console.WriteLine();
            Position = Options.Operation(Roll, Position);
            return Position;
        }
        public static int RollDice()
        {
            Random random= new Random();
            int num = random.Next(1,7);
            return num;
        }
    }

    
}