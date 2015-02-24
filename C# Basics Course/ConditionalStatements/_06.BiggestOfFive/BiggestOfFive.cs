using System;

namespace _06.BiggestOfFive
{
	class BiggestOfFive
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
				Console.WriteLine("Enter value for D!");
				double d = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter value for E!");
				double e = double.Parse(Console.ReadLine());
				double biggest;

				if (a > b)
				{
					if (a > c)
					{
						if (a > d)
						{
							if (a > e)
							{
								biggest = a;
							}
							else
							{
								biggest = e;
							}
						}
						else
						{
							if (d > e)
							{
								biggest = d;
							}
							else
							{
								biggest = e;
							}
						}
					}
					else
					{
						if (c > d)
						{
							if (c > e)
							{
								biggest = c;
							}
							else
							{
								biggest = e;
							}
						}
						else
						{
							if (d > e)
							{
								biggest = d;
							}
							else
							{
								biggest = e;
							}
						}
					}
				}
				else
				{
					if (b > c)
					{
						if (b > d)
						{
							if (b > e)
							{
								biggest = b;
							}
							else
							{
								biggest = e;
							}
						}
						else
						{
							if (d > e)
							{
								biggest = d;
							}
							else
							{
								biggest = e;
							}
						}
					}
					else
					{
						if (c > d)
						{
							if (c > e)
							{
								biggest = c;
							}
							else
							{
								biggest = e;
							}
						}
						else
						{
							if (d > e)
							{
								biggest = d;
							}
							else
							{
								biggest = e;
							}
						}
					}
				}

				Console.WriteLine ("Biggest number is: " + biggest);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
