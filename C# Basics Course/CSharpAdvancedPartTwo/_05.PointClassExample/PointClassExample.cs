using System;

namespace _05.PointClassExample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Instantiate couple of Points!");

			try
			{
				Console.Write("a.X=");
				int aX = int.Parse(Console.ReadLine());
				Console.Write("a.Y=");
				int aY = int.Parse(Console.ReadLine());
				var a = new Point(aX, aY);

				Console.Write("b.X=");
				int bX = int.Parse(Console.ReadLine());
				Console.Write("b.Y=");
				int bY = int.Parse(Console.ReadLine());
				var b = new Point(bX, bY);

//				var a = new Point(20, 30);
//				var b = new Point(0, 100);

				Console.WriteLine ("Distance between {0} and {1} = {2}", a, b, a.GetDistance(b));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
