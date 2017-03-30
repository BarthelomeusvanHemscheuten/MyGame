using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class SetGame : Form
    {

        public SetGame()
        {
            InitializeComponent();
            enemies = new List<Enemy>();
            items = new List<ICarryable>();
        }
        private Player player;
        private List<Enemy> enemies;
        private Map map;
        private Size mapsize;
        private Size cellsize;
        private IList<ICarryable> items;
        private void btnPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                int hitpoints = Convert.ToInt32(tbHitpoints_Player.Text);
                Point point = new Point(Convert.ToInt32(tbPointX_Player.Text), Convert.ToInt32(tbPointY_Player.Text));
                Player player = new Game.Player(hitpoints, point, 50);
                this.player = player;
                btnEnemy.Visible = true;
            }
            catch
            {
                MessageBox.Show("Fill in a number");
            }
        }

        private void btnEnemy_Click(object sender, EventArgs e)
        {
            try
            {
                int hitpoints = Convert.ToInt32(tbHitpoints_Enemy.Text);
                Point position = new Point(Convert.ToInt32(tbPointX_Enemy.Text), Convert.ToInt32(tbPointY_Enemy.Text));
                Enemy enemy = new Game.Enemy(hitpoints, position, player);
                enemies.Add(enemy);
                string listboxstring = "EnemyData: Hitpoints: " + enemy.Hitpoints.ToString() +
                    " Point:( " + enemy.Position.X.ToString() + " " + enemy.Position.Y.ToString() + " )";
                lbEnemies.Items.Add(listboxstring);
                btnStart.Visible = true;
                lbEnemies.Visible = true;
            }
            catch
            {
                MessageBox.Show("Fill in all fields wit numbers");
            }
            
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            try
            {
                int mapsize_x = Convert.ToInt32(tbMapWidth.Text);
                int mapsize_y = Convert.ToInt32(tbMapHeight.Text);
                SetMapSize(mapsize_x, mapsize_y);
                int goal_x = (cellsize.Height * mapsize_x) - cellsize.Height;
                int goal_y = (cellsize.Height * mapsize_y) - cellsize.Height;
                SetMapGoal(goal_x, goal_y);
                gbPlayer_Enemies.Visible = true;
                gbMap.Visible = false;
                int armor_amount = Convert.ToInt32(tbArmor.Text);
                int health_amount = Convert.ToInt32(tbHealthpacks.Text);
                MakeItems(health_amount, armor_amount);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetWorld();
            SetItems();
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
        public void SetWorld()
        {
            World.Myworld.CreateWorld(map, enemies, player);
            World.Myworld.Map.GenerateList(mapsize, cellsize);
            World.Myworld.Map.GenerateLocation();
            World.Myworld.Map.GenerateIsPassable();
            World.Myworld.Map.SetType();
            World.Myworld.Map.SetIndex();
        }
        public void SetItems()
        {
            foreach (ICarryable item in items)
            {
                item.CalculatePosition();
                item.CalculateWeight();
                item.CalculateHitpoints();
            }

            foreach (Cell cell in World.Myworld.Map.Cells)
            {
                foreach (ICarryable item in items)
                {
                    if (item.Position == cell)
                    {
                        cell.Item = item;
                    }
                }
            }
        }
        public void MakeItems(int health_amount, int armor_amount)
        {
            for (int i = 1; i <= armor_amount; i++)
            {
                Armor armor = new Armor();
                items.Add(armor);
            }
            for (int i = 1; i <= health_amount; i++)
            {
                Healthpack healthpack = new Healthpack();
                items.Add(healthpack);
            }
        }
        public void SetMapSize(int mapsize_x, int mapsize_y)
        {

            Size mapsize = new Size(mapsize_x, mapsize_y);
            Size cellsize = new Size(50, 50);
            this.mapsize = mapsize;
            this.cellsize = cellsize;
        }
        public void SetMapGoal(int goal_x, int goal_y)
        {
            Point goal = new Point(goal_x, goal_y);
            map = new Game.Map(goal);
        }
    }
}
