using System;

namespace _06.PerimeterAndAreaOfPolygon
{
	public class Point
	{

		public int X { get; set; }

		public int Y { get; set; }

		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public double GetDistance(Point otherPoint)
		{
			double distance = Math.Sqrt(Math.Pow((otherPoint.X - this.X), 2) + Math.Pow((otherPoint.Y - this.Y), 2));
			return Math.Round(distance, 2);
		}

		public override string ToString()
		{
			return string.Format("[Point: x={0}; y={1}]", this.X, this.Y);
		}
	}
}

