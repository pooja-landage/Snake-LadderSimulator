using System;

namespace SnakeLadder
{
    class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("\t    \t     \t       \t---------Welcome to snake and Ladder Game------------");
            Console.WriteLine("\n");
            int player1;
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.Write("\t    \t     \t       \t     \t  Player1 you can move {0} forward",dice);
            Console.WriteLine("\n");
        }
    }


}