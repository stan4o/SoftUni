using System;
using System.Collections.Generic;

namespace _06.PerimeterAndAreaOfPolygon
{
	public class Polygon
	{
		private List<Point> ListOfPoints { get; set; }

		public Polygon()
		{
			this.ListOfPoints = new List<Point>();
		}

		public void AddPoint(Point pointOfPolygon)
		{
			ListOfPoints.Add(pointOfPolygon);
		}

		public double GetPerimeter()
		{
			double perimeter = 0;

			for (int i = 1; i < this.ListOfPoints.Count; i++)
			{
				perimeter += ListOfPoints[i - 1].GetDistance(ListOfPoints[i]);
			}

			int listCount = this.ListOfPoints.Count;
			perimeter += ListOfPoints[0].GetDistance(ListOfPoints[listCount - 1]);

			return perimeter;
		}

		public double GetArea()
		{
			double area = 0;

			for (int i = 1; i < ListOfPoints.Count; i++)
			{
				area += (ListOfPoints[i - 1].X * ListOfPoints[i].Y) - (ListOfPoints[i - 1].Y * ListOfPoints[i].X);
			}

			area = Math.Abs(area / 2);

			return Math.Round(area, 2);
		}
	}
}

