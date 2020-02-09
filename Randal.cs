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
            Name = "Randal";
            r = new Random();
        }

        public override Roshambo GetRoshambo()
        {
            int pick = r.Next(0, 3);
            Roshambo output = (Roshambo)pick;
            return output;    
        }
    }
}
