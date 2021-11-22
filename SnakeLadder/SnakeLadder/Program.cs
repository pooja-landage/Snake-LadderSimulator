﻿using System;

namespace SnakeLadder
{
    class Program

    {
       public static void Main(string[] args)
        {
            int player1 = 0;
            int player_pos = 0;
            int Winning_pos = 100;

            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("\t    \t     \t       \t---------Welcome to snake and Ladder Game------------");
            Console.WriteLine("\n");

            Random rnd = new Random();

            while(player_pos < Winning_pos)
            {
                int dice = rnd.Next(1, 7);
                int choice = rnd.Next(1, 4);
                Console.WriteLine("Player Dice value {0} ", dice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("No Play");
                        player_pos += 0;
                        Console.WriteLine("Current position of player is :" + "  " + player_pos);
                        break;

                    case 2:
                        Console.WriteLine("Player Can go forward with Ladder");
                        player_pos += dice;
                        player_pos++;
                        Console.WriteLine("Current position of player is :" + "  " + player_pos);
                        break;

                    case 3:
                        int previous_pos = player_pos - dice;
                        Console.WriteLine("Opps.. Your Caught by Snake");
                        Console.WriteLine("Current position of player is :" + "  " + player_pos);
                        // player_pos = player_pos - dice;

                        if (previous_pos > 0)
                        {
                            player_pos = previous_pos;
                        }
                        else
                        {
                            player_pos = 0;
                        }
                        break;

                }
            }
            
            Console.WriteLine("Player won the game {0}", player_pos);
        }
    }


}

