using System;

namespace _17.CalculateGCD
{
	class CalculateGCD
	{
		public static void Main()
		{
			Console.Write("Enter value for A!");

			try
			{
				int a = int.Parse(Console.ReadLine());
				Console.Write("Enter value for B");
				int b = int.Parse(Console.ReadLine());

				while (a != 0 && b != 0)
				{
					if (a > b)
					{
						a -= b;
					}
					else
					{
						b -= a;
					}
				}

				int gcd = Math.Max(a, b);

				Console.WriteLine ("GCD = " + gcd);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
