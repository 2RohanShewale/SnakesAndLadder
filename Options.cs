namespace SnakesAndLadder
{
    internal class Options
    {
        public static int Operation(int die, int startposition)
        {
            Random num = new Random();
            int option = num.Next(1,4);
            switch (option)
            {
                case 1:startposition = NoPlay(die,startposition); break;
                case 2:startposition = Ladder(die,startposition); break;
                case 3:startposition = Snake(die,startposition); break;
            }
            return startposition;
        }

        static int NoPlay(int die,int startposition)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("NO play");
            Console.ResetColor();

            return startposition;
        }

        static int Ladder(int die,int startposition)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Congrats You got ladder");
            startposition += die;
            Console.ResetColor();
            return startposition;

        }
        static int Snake(int die,int startposition)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine("Sorry you got snake");
            Console.ResetColor();
            startposition -= die;
            return startposition;
        }
    }
}
