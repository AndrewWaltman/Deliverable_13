using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    abstract class Player
    {
        public string Name { get; set; }

        public virtual Roshambo GetRoshambo()
        {
            return Roshambo.Rock;
        }
    }
    public enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }
}
