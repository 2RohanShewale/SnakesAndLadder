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
            List<Player> list = new List<Player>();
            
            Console.ReadKey();
            Console.Write("Add Name of the player 1 : "); string player1Name = Console.ReadLine();
            Console.Write("Add Name of the player 2 : "); string player2Name = Console.ReadLine();
            list.Add(new Player() { Name = player1Name});
            list.Add(new Player() { Name = player2Name});
            int i = 0;
            list[i].NumberOfRolls = 0; list[i].Position = 0;

            bool PlayGame = true;
            while (PlayGame)
            {
                list[i].Position = Play(list[i],list[i].Position, list[i].NumberOfRolls);
                list[i].NumberOfRolls++;
                if (list[i].Position <= 0) 
                {
                    Console.WriteLine("You went under 0: ");
                    Console.WriteLine();
                    list[i].Position = 0;
                    list[i].NumberOfRolls = 0;
                }
                else if(list[i].Position == 100)
                {
                    break;
                }
                if (!list[i].Ladder)
                {
                    if (i == 0) { i = 1; }
                    else
                    {
                        i = 0;
                    }
                }
            }
            Console.WriteLine("*---------------------*");
            Console.WriteLine($"{list[i].Name} has won You rolled {list[i].NumberOfRolls} times");
            Console.WriteLine("*---------------------*");

        }

        public static int Play(Player player,int Position,int NumberOfRolls)
        {
            Console.WriteLine();
            Console.WriteLine($"{player.Name}'s turn ");
            if (!(Position == 0 && NumberOfRolls == 0)) { Console.WriteLine("You are at position: " + Position + $". You have rolled {NumberOfRolls} times"); }
            Console.WriteLine("Press a key to Roll.");
            Console.ReadKey();
            
            
            int Roll = RollDice();
            Console.WriteLine("You have Rolled: " + Roll);
            Console.WriteLine();
            Position = Options.Operation(player ,Roll, Position);
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