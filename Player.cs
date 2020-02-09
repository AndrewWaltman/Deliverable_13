using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverable_13
{
    //Here is the player class, and the Parent Class.
    //Player is made as an abstract because the Lab asked us to.
    abstract class Player
    {
        //Stores a Name Value (And required for every other Child Class.)
        public string Name { get; set; }

        //This creates a Roshambo value, makes it virtual so it can be overridden later. The current return doesn't matter basically.
        public virtual Roshambo GetRoshambo()
        {
            return Roshambo.rock;
        }
    }
    //Here is the first things asked of us, the enum Roshambo with the values Rock, Paper, and Scissors.
    //Creating an enum is fairly similar to creating other variables, however, it is an enum and not inheritely a string or int.
    //When calling an enum, we may have to change the typing for later.
    public enum Roshambo
    {
        rock,
        paper,
        scissors
    }
}
