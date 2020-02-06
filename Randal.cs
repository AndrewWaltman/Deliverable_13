using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    class Randal : Player
    {
        public Random r { get; set; }

        public Randal()
        {
            r = new Random();
        }

        public Roshambo GetRoshambo()
        {
            int pick = r.Next(0, 3);
            Roshambo output = (Roshambo)pick;
            return output;    
        }
        //Random Number Generator code, may be used later.

        //public int RandomNumber(int a, int b)
        //{
        //    Random random = new Random();
        //    return random.Next(1, 3);
        //}
    }
}
