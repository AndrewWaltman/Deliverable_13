using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    class Human : Player
    {
        public Human()
        {
            Console.WriteLine("Please input your name.");
            Name = Console.ReadLine();
        }
        public override Roshambo GetRoshambo()
        {
            Console.WriteLine("Please select Rock, Paper, or Scissors");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == Roshambo.rock.ToString())
            {
                return Roshambo.rock;
            }
            else if (input == Roshambo.paper.ToString())
            {
                return Roshambo.paper;
            }
            else if (input == Roshambo.scissors.ToString())
            {
                return Roshambo.scissors;
            }
            else
            {
                Console.WriteLine("Sorry, that was not a valid response.");
                return GetRoshambo();
            }

        }

    }
}
