using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{
    class AI
    {
        private Point enemyposition;

        public string Calculate_Action(Point enemyposition, Player player)
        {
            Point playerposition = player.Position;
            this.enemyposition = enemyposition;
            int dif_orgx = enemyposition.X - playerposition.X;
            int dif_orgy = enemyposition.Y - playerposition.Y;
            if (dif_orgy >= 0 && dif_orgx <= 0)
            {
                int dif_posx = Math.Abs(dif_orgx);
                int dif_posy = Math.Abs(dif_orgy);
                if (dif_posy >= dif_posx)
                {
                    return "up";
                }
                else if (dif_posx >= dif_posy)
                {
                    return "right";
                }
            }
            else if (dif_orgy <= 0 && dif_orgx >= 0)
            {
                int dif_posx = Math.Abs(dif_orgx);
                int dif_posy = Math.Abs(dif_orgy);
                if (dif_posy >= dif_posx)
                {
                    return "down";
                }
                else if (dif_posx >= dif_posy)
                {
                    return "left";
                }
            }
            else if (dif_orgy >= 0 && dif_orgx >= 0)
            {
                int dif_posx = Math.Abs(dif_orgx);
                int dif_posy = Math.Abs(dif_orgy);
                if (dif_posy >= dif_posx)
                {
                    return "up";
                }
                else if (dif_posx >= dif_posy)
                {
                    return "left";
                }

            }
            else if (dif_orgy <= 0 && dif_orgx <= 0)
            {
                int dif_posx = Math.Abs(dif_orgx);
                int dif_posy = Math.Abs(dif_orgy);
                if (dif_posy >= dif_posx)
                {
                    return "down";
                }
                else if (dif_posx >= dif_posy)
                {
                    return "right";
                }
            }
            return "nothing";
        }
        public Point Move(Point enemyposition, Player player)
        {
            Random rand = new Random();
            bool choice = rand.Next(2) == 0;
            string action = Calculate_Action(enemyposition, player);
            int widthcell = 0;
            foreach (Cell c in World.Myworld.Map.Cells)
            {
                widthcell = c.Size.Height;
                break;
            }
            Point newpoint = Calculate_Position(widthcell, action);
            Cell cell = World.Myworld.Map.GetCell(newpoint);
            if (!cell.IsPassable && choice)
            {
                switch (action)
                {
                    case "up":
                        newpoint = Calculate_Position(widthcell, "left");
                        break;

                    case "down":
                        newpoint = Calculate_Position(widthcell, "right");
                        break;

                    case "right":
                        newpoint = Calculate_Position(widthcell, "up");
                        break;

                    case "left":
                        newpoint = Calculate_Position(widthcell, "down");
                        break;
                }
            }
            else if (!cell.IsPassable && !choice)
            {
                switch (action)
                {
                    case "up":
                        newpoint = Calculate_Position(widthcell, "right");
                        break;

                    case "down":
                        newpoint = Calculate_Position(widthcell, "left");
                        break;

                    case "right":
                        newpoint = Calculate_Position(widthcell, "down");
                        break;

                    case "left":
                        newpoint = Calculate_Position(widthcell, "up");
                        break;
                }

            }

            return newpoint;


        }
        public Point Calculate_Position(int widthcell, string action)
        {
            Point newpoint = new Point(0, 0);
            switch (action)
            {
                case "up":
                    newpoint = new Point(this.enemyposition.X, this.enemyposition.Y - widthcell);
                    break;
                case "down":
                    newpoint = new Point(this.enemyposition.X, this.enemyposition.Y + widthcell);
                    break;
                case "left":
                    newpoint = new Point(this.enemyposition.X - widthcell, this.enemyposition.Y);
                    break;
                case "right":
                    newpoint = new Point(this.enemyposition.X + widthcell, this.enemyposition.Y);
                    break;
            }
            if (newpoint.X >= 0 && newpoint.Y >= 0)
            {
                return newpoint;
            }
            return enemyposition;
        }

    }
}
