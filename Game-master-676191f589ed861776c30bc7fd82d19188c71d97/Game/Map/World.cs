using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    class World
    {
        //Fields
        private Map map;
        private List<Enemy> enemies;
        private Player player;
        private static World myworld;

        //Properties
        public Map Map { get { return map; } set { map = value; } }
        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public static World Myworld
        {
            get
            {
                if (myworld == null)
                {
                    myworld = new World();
                }
                return myworld;
            }
            set { myworld = value; }
        }
        public List<Enemy> Enemies
        {
            get { return enemies; }
            set { enemies = value; }
        }
        //Methods
        public void CreateWorld(Map map, List<Enemy> enemies, Player player)
        {
            this.map = map;
            this.enemies = enemies;
            this.player = player;
        }


        public void DrawMap(Graphics x)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush wall_brush = new SolidBrush(Color.Black);
            SolidBrush goal_brush = new SolidBrush(Color.Green);
            Rectangle[] normal_rectangles = new Rectangle[map.Cells.Count];
            Rectangle[] wall_rectangles = new Rectangle[map.Cells.Count];
            Rectangle goal_rectangle = new Rectangle();
            Rectangle start_rectangle = new Rectangle();
            int i = 0;
            foreach (Cell cell in map.Cells)
            {
                Rectangle rectangle = new Rectangle(cell.Location, cell.Size);
                if (cell.Type == "Wall")
                {
                    wall_rectangles[i] = rectangle;
                    i++;
                }
                else if (cell.Type == "Goal")
                {
                    goal_rectangle = rectangle;
                    wall_rectangles[i] = rectangle;
                    i++;
                }
                else if (cell.Type == "Normal")
                {
                    normal_rectangles[i] = rectangle;
                    i++;
                }
                else if (cell.Type == "Start")
                {
                    start_rectangle = new Rectangle(cell.Location, cell.Size);
                }
            }
            x.DrawRectangles(pen, normal_rectangles);
            x.DrawRectangles(pen, wall_rectangles);
            x.DrawRectangle(pen, start_rectangle);
            x.FillRectangles(wall_brush, wall_rectangles);
            x.FillRectangle(goal_brush, goal_rectangle);
        }
        public void DrawPlayer_Enemies(Graphics x)
        {
            Pen pen = new Pen(Color.Black, 5);
            SolidBrush player_brush = new SolidBrush(Color.Blue);
            SolidBrush enemy_brush = new SolidBrush(Color.Red);
            SolidBrush textbrush = new SolidBrush(Color.Black);
            Font font = new Font(FontFamily.GenericSansSerif, 17.0F, FontStyle.Bold);
            Size cellsize = new Size(0, 0);
            foreach (Cell cell in map.Cells)
            {
                cellsize = cell.Size;
                break;
            }
            x.DrawEllipse(pen, player.Position.X, player.Position.Y, cellsize.Height, cellsize.Width);
            x.FillEllipse(player_brush, player.Position.X, player.Position.Y, cellsize.Height, cellsize.Width);
            x.DrawString(player.Hitpoints.ToString(), font, textbrush, player.Position.X, player.Position.Y + 10);
            foreach (Enemy enemy in enemies)
            {
                x.DrawEllipse(pen, enemy.Position.X, enemy.Position.Y, cellsize.Height, cellsize.Width);
                x.FillEllipse(enemy_brush, enemy.Position.X, enemy.Position.Y, cellsize.Height, cellsize.Width);
                if (!enemy.Dead)
                {
                    x.DrawString(enemy.Hitpoints.ToString(), font, textbrush, enemy.Position.X, enemy.Position.Y + 10);
                }
                else if (enemy.Dead)
                {
                    Font dead_font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                    x.DrawString("Dead", dead_font, textbrush, enemy.Position.X, enemy.Position.Y + 10);
                }
            }
        }
        public void DrawItems(Graphics x)
        {
            SolidBrush armorbrush = new SolidBrush(Color.Black);
            SolidBrush healthbrush = new SolidBrush(Color.Red);
            Font font = new Font(FontFamily.GenericSansSerif, 17.0F, FontStyle.Bold);
            foreach(Cell cell in myworld.map.Cells)
            {
                if (cell.Item is Armor)
                {
                    x.DrawString(cell.Item.Hitpoints.ToString(), font, armorbrush, cell.Location);
                }
                else if(cell.Item is Healthpack)
                {
                    x.DrawString(cell.Item.Hitpoints.ToString(), font, healthbrush, cell.Location);
                }
            }

        }

    }
}
