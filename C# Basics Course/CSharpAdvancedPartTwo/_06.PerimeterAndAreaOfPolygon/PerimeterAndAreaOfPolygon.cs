using System;

namespace _06.PerimeterAndAreaOfPolygon
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter number of Points to add!");

			try
			{
				var polygon = new Polygon();
				int numberOfPoints = int.Parse(Console.ReadLine());

				if (numberOfPoints < 3)
				{
					throw new Exception("Cannot create polygon with less than 3 points!");
				}

				for (int i = 0; i < numberOfPoints; i++)
				{
					string[] currentPoint = Console.ReadLine().Split(' ');
					int cpX = int.Parse(currentPoint[0]);
					int cpY = int.Parse(currentPoint[1]);
					polygon.AddPoint(new Point(cpX, cpY));
				}

				Console.WriteLine ("perimeter = " + polygon.GetPerimeter());
				Console.WriteLine ("area = " + polygon.GetArea());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
