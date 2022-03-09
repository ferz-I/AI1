using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class Robot
    {
        public Point LastLocation = new();
        public Point Location = new();
        public Point Direction = new() { X = 1, Y = 0 };
        public void GoForward()
        {
            Location.X += Direction.X;
            Location.Y += Direction.Y;
        }

    }

}
