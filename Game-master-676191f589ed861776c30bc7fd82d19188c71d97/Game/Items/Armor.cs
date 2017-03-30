using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Game
{
    class Armor : ICarryable
    {
        private int weight;
        private Cell position;
        private int hitpoints;

        public int Weight { get { return weight; } }
        public Cell Position { get { return position; } set { position = value; } }
        public int Hitpoints { get { return hitpoints; } }


        public void CalculatePosition()
        {
            List<Cell> normalcells = new List<Cell>();
            foreach (Cell cell in World.Myworld.Map.Cells)
            {
                if (cell.Type == "Normal" && cell.Item == null)
                {
                    normalcells.Add(cell);
                }
            }
            Random rand = new Random();
            int random = rand.Next(0, normalcells.Count);
            int count = 0;
            foreach (Cell cell in normalcells)
            {
                count++;
                if(count == random)
                {
                    this.position = cell;
                    break;
                }
            }

        }
        public void CalculateWeight()
        {
            Random rand = new Random();
            this.weight = rand.Next(10, 50);
        }
        public void CalculateHitpoints()
        {
            this.hitpoints = this.weight;
        }
    }
}
