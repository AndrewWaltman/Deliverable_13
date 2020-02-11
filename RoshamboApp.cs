using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    class RoshamboApp
    {
        Player Player1 { get; set; }
        Player Player2 { get; set; }

        public RoshamboApp()
        {
            Player1 = new Human();
            while (true)
            {
            Console.WriteLine("Please select an opponent!: (1)Brock or (2)Randal. (Insert their number please.)");
            string input = Console.ReadLine().Trim().ToLower();

                if (input == "1")
                {
                    Player2 = new Brock();
                    break;
                }
                else if (input == "2")
                {
                    Player2 = new Randal();
                    break;
                }
                else
                {
                    Console.WriteLine("That was an invalid response, please try again.");
                }
            }
            Console.WriteLine("Thank you for the info. Please press \"enter\" to continue.");
            Console.ReadLine();
            
            Console.Clear();
            Play();
        }

        //Must put these integers out of the loop so that they don't auto to 0 every single time.
        int winScore = 0;
        int loseScore = 0;
        int drawScore = 0;

        public void Play()
        {
            //Here's  where we include the Player1 choice of the match.
            Console.WriteLine($"{Player1.Name}'s turn.");
            Roshambo p1throw = Player1.GetRoshambo();
            Console.WriteLine("=======================================");

            //Here's where the opponent plays, and their result is posted.
            Console.WriteLine($"{Player2.Name}'s turn.");
            Roshambo p2throw = Player2.GetRoshambo();
            Console.WriteLine(". . . .");

            Console.WriteLine("=======================================");

            Console.WriteLine($"{Player1.Name} : {p1throw}");
            Console.WriteLine($"{Player2.Name} : {p2throw}");
            
            //Now we validate who won the match. Rock beats Scissors, Scissors beats Paper, Paper beats Rock.
            //Both of the results being the same is a draw.
            if (p1throw == p2throw)
            {
                //Displays the message
                Console.WriteLine("That match was a draw.");
                //Adjusts the score
                ++drawScore;
            }
            else if (p1throw == Roshambo.rock && p2throw == Roshambo.scissors)
            {
                Console.WriteLine($"{Player1.Name} wins!");
                ++winScore;
            }
            else if (p1throw == Roshambo.rock && p2throw == Roshambo.paper)
            {
                Console.WriteLine($"{Player2.Name} wins!");
                ++loseScore;
            }
            else if(p1throw == Roshambo.paper && p2throw == Roshambo.rock)
            {
                Console.WriteLine($"{Player1.Name} wins!");
                ++winScore;
            }
            else if(p1throw == Roshambo.paper && p2throw == Roshambo.scissors)
            {
                Console.WriteLine($"{Player2.Name} wins!");
                ++loseScore;
            }
            else if(p1throw == Roshambo.scissors && p2throw == Roshambo.paper)
            {
                Console.WriteLine($"{Player1.Name} wins!");
                ++winScore;
            }
            else if (p1throw == Roshambo.scissors && p2throw == Roshambo.rock)
            {
                Console.WriteLine($"{Player2.Name} wins!");
                ++loseScore;
            }

            //We then go to a continue loop.
            while(true)
            {
                Console.WriteLine("Would you like to play agian (Y/N)");
                string yn = Console.ReadLine().ToLower().Trim();

                if(yn == "y")
                {
                    Console.Clear();
                    Console.WriteLine($"======================================= \n{Player1.Name} vs {Player2.Name}\n=======================================");
                    Console.WriteLine($"The Score is :: Wins: {winScore} Losses: {loseScore} Draws: {drawScore}");
                    Console.WriteLine("=======================================");
                    Play();
                }
                else if(yn == "n")
                {
                    Console.WriteLine("Thank you for playing. (Press \"enter\"  to exit)\n");
                    Console.ReadLine();
                    Environment.Exit(0); //A fancy way to exit the application once the response is made.
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't quite get that.");
                }
            }
        }
    }
}
