using System;

namespace Deliverable_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================= \nWelcome to the Rock Paper Scissors App\n=======================================");

            Console.WriteLine("What is your name?");
            string name  = Console.ReadLine().Trim();

            Console.WriteLine("Who would you like your opponent to be? \n(1)Rocky\n   or \n(2)Randal");
            string response = Console.ReadLine().Trim();

            if (response == "1")
            {
                Console.WriteLine("You chose Rocky.");
            }
            else if (response == "2")
            {
                Console.WriteLine("You chose Randal.");
            }
        }
    }
}
