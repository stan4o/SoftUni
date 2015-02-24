using System;

namespace _05.BiggestOfThree
{
	class BiggestOfThree
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for A!");

			try
			{
				double a = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter value for B!");
				double b = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter value for C!");
				double c = double.Parse(Console.ReadLine());

				double biggest;

				if (a > b)
				{
					if (a > c)
					{
						biggest = a;
					}
					else
					{
						biggest = c;
					}
				}
				else
				{
					if (c > b)
					{
						biggest = c;
					}
					else
					{
						biggest = b;
					}
				}

				Console.WriteLine ("Bigest number is: " + biggest);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
