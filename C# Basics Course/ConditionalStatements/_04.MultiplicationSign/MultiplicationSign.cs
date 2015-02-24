using System;

namespace _04.MultiplicationSign
{
	class MultiplicationSign
	{
		public static void Main()
		{
			Console.WriteLine("Enter variable A!");

			try
			{
				double a = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter variable B!");
				double b = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter variable C!");
				double c = double.Parse(Console.ReadLine());

				if (a == 0 || b == 0 || c == 0)
				{
					Console.WriteLine ("Result: 0");
				}
				else
				{
					if (a > 0)
					{
						if (b > 0)
						{
							if (c > 0)
							{
								Console.WriteLine ("Result: +");
							}
							else
							{
								Console.WriteLine ("Result: -");
							}
						}
						else
						{
							if (c > 0)
							{
								Console.WriteLine ("Result: -");
							}
							else
							{
								Console.WriteLine ("Result: +");
							}
						}
					}
					else
					{
						if (b > 0)
						{
							if (c > 0)
							{
								Console.WriteLine ("Result: -");
							}
							else
							{
								Console.WriteLine ("Result: +");
							}
						}
						else
						{
							if (c > 0)
							{
								Console.WriteLine ("Result: +");
							}
							else
							{
								Console.WriteLine ("Result: -");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
