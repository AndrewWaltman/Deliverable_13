using System;

namespace Deliverable_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================= \nWelcome to the Rock Paper Scissors App\n=======================================");

            Human h = new Human();
            Console.WriteLine(h.GetRoshambo());

            Randal ra = new Randal();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ra.GetRoshambo());
            }
        }
    }
}
