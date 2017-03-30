using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    class Player : Character
    {
        private int maxweight;
        private int currentweight;
        private ICarryable item;
        public Player(int hitpoints, Point position, int maxweight)
            : base(hitpoints, position)
        {
            this.maxweight = maxweight;
        }

        //Moves the player, also checks if the position is in the map or doesnt have a wall.
        public void Move(KeyEventArgs e)
        {
            Point oldpoint = this.Position;
            Point newpoint = new Point(0, 0);
            int widthcell = 0;
            foreach (Cell c in World.Myworld.Map.Cells)
            {
                widthcell = c.Size.Height;
            }
            switch (e.KeyCode)
            {
                case Keys.Up:
                    newpoint = new Point(this.Position.X, this.Position.Y - widthcell);
                    break;
                case Keys.Down:
                    newpoint = new Point(this.Position.X, this.Position.Y + widthcell);
                    break;
                case Keys.Left:
                    newpoint = new Point(this.Position.X - widthcell, this.Position.Y);
                    break;
                case Keys.Right:
                    newpoint = new Point(this.Position.X + widthcell, this.Position.Y);
                    break;
                case Keys.Space:
                    Attack();
                    newpoint = this.Position;
                    break;
            }
            Cell cell = World.Myworld.Map.GetCell(newpoint);
            if (!cell.IsPassable)
            {
                this.Position = oldpoint;
            }
            else if (newpoint.X >= 0 && newpoint.Y >= 0)
            {
                this.Position = newpoint;
            }
        }

        public void Attack()
        {

            foreach (Enemy enemy in World.Myworld.Enemies)
            {
                if (enemy.Position == this.Position && !enemy.Dead)
                {
                    enemy.Hitpoints -= 20;
                    if (enemy.Hitpoints <= 0)
                    {
                        enemy.Dead = true;
                    }
                }
            }

        }
        public void PickUp(ICarryable item, Cell cell)
        {
            currentweight += item.Weight;
            if (maxweight >= currentweight)
            {
                this.item = item;
                Hitpoints += item.Hitpoints;
                cell.Item = null;
            }
        }

    }
}
