using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{

    class Cell
    {
        private string type;
        private Point location;
        private bool isPassable;
        private Size size;
        private int index;
        private ICarryable item;

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }
        public ICarryable Item { get { return item; } set { item = value; } }

        public int Index { get { return index; } set { index = value; } }
        public bool IsPassable { get { return isPassable; } set { isPassable = value; } }

        public string Type { get { return type; } set { type = value; } }

        public Size Size { get { return size; } set { size = value; } }

    }
}
