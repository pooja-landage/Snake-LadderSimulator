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
            Console.Write("\t    \t     \t       \t     \t   Enter value of Player: ");
            
            string Name = Console.ReadLine();
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.WriteLine("\n");
            Console.Write("\t    \t     \t       \t     \t   {0} you can move {1} forward  ",Name,dice);
           
        }
    }


}

