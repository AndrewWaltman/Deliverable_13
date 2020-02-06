using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    class Rocky : Player
    {
        public Rocky()
        {
            Name = "Rocky";
        }
        public override Roshambo GetRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
