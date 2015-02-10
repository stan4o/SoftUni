using System;

namespace _6.QuadraticEquation
{
	class QuadraticEquation
	{
		public static void Main ()
		{
			try
			{
				Console.WriteLine ("Enter value for a != 0!");
				double a = double.Parse (Console.ReadLine ());

				if (a == 0)
				{
					throw new Exception ("Must not be equal to 0!");
				}

				Console.WriteLine ("Enter value for b!");
				double b = double.Parse (Console.ReadLine ());
				
				Console.WriteLine ("Enter value for c!");
				double c = double.Parse (Console.ReadLine ());
				
				double discriminant = Math.Pow (b, 2) - 4d * a * c;
				
				if (discriminant > 0)
				{
					double x1 = (-b - Math.Sqrt (Math.Pow (b, 2) - 4d * a * c)) / (2d * a);
					double x2 = (-b + Math.Sqrt (Math.Pow (b, 2) - 4d * a * c)) / (2d * a);
					Console.WriteLine ("Result: x1={0}; x2={1};", x1, x2);
				}
				else if (discriminant == 0)
				{
					double x1 = (-b - Math.Sqrt (Math.Pow (b, 2) - 4d * a * c)) / (2d * a);
					Console.WriteLine ("Result: x1=x2={0};", x1);
				}
				else
				{
					Console.WriteLine ("There are no real roots!");
				}


			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}
		}
	}
}
