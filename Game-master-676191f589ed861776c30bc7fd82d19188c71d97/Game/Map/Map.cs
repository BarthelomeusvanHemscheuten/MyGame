using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{
    class Map
    {
        //Fields
        private Point goal;
        private Point start;
        private List<Cell> cells;
        private Size size;

        //Properties
        public List<Cell> Cells
        {
            get { return cells; }
         }

        //Constructor
        public Map(Point goal)
        {
            start = new Point { X = 0, Y = 0 };
            this.goal = goal;
        }
        //Sets a list full of empty cells.
        public void GenerateList(Size sizemap, Size sizecell)
        {
            this.size = sizemap;
            cells = new List<Cell>();

            int amount = this.size.Height * this.size.Width;
            for (int i = 0; i <= amount; i++)
            {
                Cell empty_cell = new Cell();
                empty_cell.Size = sizecell;
                cells.Add(empty_cell);
            }

        }
        //Generates a location for each cell, so that all cells line up in their positions
        public void GenerateLocation()
        {
            int x = 0;
            int y = 0;
            int count = 0;
            int max_x = size.Width;
            int max_y = size.Height;
            foreach (Cell cell in cells)
            {
                cell.Location = new Point(x, y);
                x += cell.Size.Width;
                max_x = size.Width * cell.Size.Width;
                max_y = size.Height * cell.Size.Height;
                if (x == max_x && y < max_y)
                {
                    count++;
                    if (count == this.size.Height)
                    {
                        break;
                    }
                    x = 0;
                    y += cell.Size.Height;


                }
            }
        }
        //Gets rid of wall cluter by making cells around a wall passable
        public List<Cell> Get_Surrounding_Cells(Cell cell)
        {
            Point mycellpoint = cell.Location;
            List<Cell> returncells = new List<Cell>();
            int size = cell.Size.Height;
            int x = cell.Location.X;
            int min_x = cell.Location.X - size;
            int max_x = cell.Location.X + size;
            int y = cell.Location.Y;
            int min_y = cell.Location.Y - size;
            int max_y = cell.Location.Y + size;
            foreach (Cell listcell in this.cells)
            {
                if ((listcell.Location.X >= min_x && listcell.Location.X <= max_x))
                {
                    if ((listcell.Location.Y >= min_y && listcell.Location.Y <= max_y) && listcell.Location != cell.Location)
                    {
                        returncells.Add(listcell);
                    }
                }

            }

            return returncells;

        }
        //Makes random cells unpassable, but makes a path around the field for more freedon
        //There also cant be a wall on the location of an enemy or goal
        public void GenerateIsPassable()
        {
            List<Cell> notpassable = new List<Cell>();
            Random rand = new Random();
            foreach (Cell cell in cells)
            {
                int x = cell.Location.X;
                int y = cell.Location.Y;
                int size = cell.Size.Width;
                cell.IsPassable = rand.Next(0, 100) > 10;
                foreach (Enemy en in World.Myworld.Enemies)
                {
                    if (!cell.IsPassable)
                    {
                        foreach (Cell listcell in Get_Surrounding_Cells(cell))
                        {
                            notpassable.Add(listcell);
                        }
                        if(cell.Type == "Start" || cell.Type == "Goal")
                        {
                            notpassable.Add(cell);
                        }    

                        if ( cell.Location == en.Position || notpassable.Contains(cell))
                        {
                            cell.IsPassable = true;
                        }
                    }
                }
            }
        }
        //Sets the type of the cell, depending on certain conditions
        public void SetType()
        {
            foreach (Cell cell in cells)
            {
                if (cell.Location == goal)
                {
                    cell.Type = "Goal";
                }
                else if (cell.Location == start)
                {
                    cell.Type = "Start";
                }
                else if (!cell.IsPassable)
                {
                    cell.Type = "Wall";
                }
                else if (cell.IsPassable)
                {
                    cell.Type = "Normal";
                }
            }

        }
        public void SetIndex()
        {
            int count = 0;
            foreach(Cell cell in cells)
            {
                cell.Index = count;
                count++;
            }
        
        }
        //Gets the cel of a given position
        public Cell GetCell(Point position)
        {
            Cell empty_cell = new Cell();
            foreach (Cell cell in World.Myworld.Map.cells)
            {
                if (cell.Location == position)
                {
                    empty_cell = cell;
                }
            }
            return empty_cell;
        }

    }
}
