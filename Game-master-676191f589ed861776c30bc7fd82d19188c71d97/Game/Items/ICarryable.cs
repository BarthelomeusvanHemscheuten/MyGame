using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Game
{
    interface ICarryable
    {
       int Weight { get; }
       int Hitpoints { get; }
       Cell Position { get; set; }

        void CalculatePosition();

        void CalculateWeight();
        void CalculateHitpoints();
    }
}
