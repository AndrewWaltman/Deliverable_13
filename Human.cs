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
            Console.WriteLine("Please select Rock, Paper, or Scissors (please keep to capitalization)");
            string input = Console.ReadLine().Trim();

            if (input == Roshambo.Rock.ToString())
            {
                return Roshambo.Rock;
            }
            else if (input == Roshambo.Paper.ToString())
            {
                return Roshambo.Paper;
            }
            else if (input == Roshambo.Scissors.ToString())
            {
                return Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Sorry, that was not a valid response.");
                return GetRoshambo();
            }

        }

    }
}
