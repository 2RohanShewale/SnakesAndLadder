namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes and ladder game");
            int startposition = 0;
            Console.WriteLine("You are at position " + 0);
            Console.WriteLine("press any key to roll");
            Console.ReadKey();
            Random num = new Random();
            int die = num.Next(1,7);
            Console.WriteLine("YOu have rolled this " + die);
        }
        
    }
}