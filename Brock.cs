﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    class Brock : Player
    {
        public Brock()
        {
            Name = "Brock";
        }
        public override Roshambo GetRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
