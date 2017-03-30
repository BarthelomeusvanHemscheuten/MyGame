using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{
    abstract class Character
    {
        //Fields
        private int hitpoints;
        public string action;
        private Point position;
        private ICarryable item;

        //Properties
        public Point Position { get { return position; }set { position = value; } }
        public int Hitpoints { get { return hitpoints; } set { hitpoints = value; } }
   
        //Methods
        public Character(int hitpoints, Point position)
        {
            this.hitpoints = hitpoints;
            this.position = position;
        }
        public Character()
        {

        }
        public void GetHit()
        {
            this.hitpoints -= 1;
        }
 

    }
}
