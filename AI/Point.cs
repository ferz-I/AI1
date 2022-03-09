using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
	public class Point
	{
		public int X;
		public int Y;
		public Point Rotate(int angle)
		{
			if (angle > 0)
				return new Point() { X = Y, Y = -X };
			else
				return new Point() { X = -Y, Y = X };
		}
		public Point(int x, int y)
        {
			X = x;
			Y = y;
        }
		public Point() { }
		public static Point operator +(Point p1, Point p2)
		{
			return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
		}

	}
}
