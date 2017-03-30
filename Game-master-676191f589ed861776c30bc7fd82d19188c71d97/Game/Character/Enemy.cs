using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{
    class Enemy : Character
    {
        private Player player;
        private bool dead;

        public bool Dead { get { return dead; } set { dead = value; } }
        
        public Enemy(int hitpoints, Point position, Player player) 
            : base(hitpoints, position)
        {
            this.player = player;
        }
        public Enemy()
        {

        }

        public void MoveEnemy()
        {
            if (!dead)
            {
                AI ai = new AI();
                this.Position = ai.Move(this.Position, this.player);
            }
        }
    }
}
