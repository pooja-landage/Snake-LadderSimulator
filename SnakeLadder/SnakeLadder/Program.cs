using System;

namespace SnakeLadder
{
    class Program

    {
        public const int NO_PLAY = 1;
        public const int SNAKE_BITE = 2;
        public const int LADDER = 3;
        public static void Main(string[] args)
        {
            int player1 = 0;
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("\t    \t     \t       \t---------Welcome to snake and Ladder Game------------");
            Console.WriteLine("\n");
            Random rnd = new Random();
            int dice = rnd.Next(0, 4);
            switch (dice)
            {
                case NO_PLAY:
                    Console.WriteLine("\t    \t     \t       \t  Dice value {0} ", dice);
                    Console.WriteLine("\t    \t     \t       \t  You can not Move Forward");
                    player1 = 0;
                    break;
                case SNAKE_BITE:
                    Console.WriteLine("\t    \t     \t       \t  Dice value {0} ", dice);
                    Console.WriteLine("\t    \t     \t       \t Snake Bite");
                    player1 = 0;
                    break;
                case LADDER:
                    Console.WriteLine("\t    \t     \t       \t  Dice value {0} ", dice);
                    Console.WriteLine("\t    \t     \t       \t you can climb Ladder");
                    player1 = 0;
                    break;
                default:
                    Console.WriteLine("\t    \t     \t       \t  Dice value {0} :", dice);
                    Console.WriteLine("\t    \t     \t       \t  Oppss Error");
                    break;
            }
            Console.WriteLine("\n");






        }
    }


}

