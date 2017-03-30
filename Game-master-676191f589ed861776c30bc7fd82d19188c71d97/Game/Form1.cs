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
    public partial class Form1 : Form
    {
        private World world;
        private Point goal;

        public Form1()
        {
            world = World.Myworld;
            InitializeComponent();
            tmEnemy.Interval = 100;
            tmEnemy.Start();
            tmDraw.Interval = 10;
            tmDraw.Start();
            foreach(Cell cell in world.Map.Cells)
            {
                if(cell.Type == "Goal")
                {
                    goal = cell.Location;
                }
            }
       
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            world.DrawMap(e.Graphics);
            world.DrawPlayer_Enemies(e.Graphics);
            world.DrawItems(e.Graphics);
            foreach (Enemy en in world.Enemies)
            {
                if (world.Player.Position == en.Position && !en.Dead)
                {
                    world.Player.GetHit();
                }
            }
            Cell cell = world.Map.GetCell(world.Player.Position);
            if(cell.Item != null)
            {
                ICarryable item = cell.Item;
                world.Player.PickUp(item, cell);
            }
            if(world.Player.Hitpoints <= 0)
            {
                this.Hide();
                MessageBox.Show("Game over");
                Application.Exit();
            }
            if(world.Player.Position == goal)
            {
                this.Hide();
                MessageBox.Show("You won");
                Application.Exit();
            }

        }

        private void Control_Player(object sender, KeyEventArgs e)
        {
            world.Player.Move(e);
        }

        private void tmEnemy_Tick(object sender, EventArgs e)
        {
            foreach (Enemy en in world.Enemies)
            {
                en.MoveEnemy();
                         
            }
            Random rand = new Random();
            tmEnemy.Interval = rand.Next(1, 700);

        }

        private void tmDraw_Tick(object sender, EventArgs e)
        {
            pbMap.Refresh();
        }
    }
}
