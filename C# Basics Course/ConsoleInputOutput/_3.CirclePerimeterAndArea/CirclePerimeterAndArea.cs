using System;

namespace _3.CirclePerimeterAndArea
{
	class CirclePerimeterAndArea
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter Circle's radius!");
			double radius = double.Parse (Console.ReadLine ());
			double circlePerimeter = Math.PI * 2d * radius;
			double circleArea = Math.PI * Math.Pow(radius, 2);

			Console.WriteLine ("Circle's Perimeter: {0:F2}", circlePerimeter);
			Console.WriteLine ("Circle's Area: {0:F2}", circleArea);
		}
	}
}
