using System;

namespace _07.SortThreeNumbers
{
	class SortThreeNumbers
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
				double first, second, third;

				if (a > b)
				{
					if (a > c)
					{
						if (b > c)
						{
							second = b;
							third = c;
						}
						else
						{
							second = c;
							third = b;
						}

						first = a;
					}
					else
					{
						first = c;
						second = a;
						third = b;
					}
				}
				else
				{
					if (a > c)
					{
						first = b;
						second = a;
						third = c;
					}
					else
					{
						third = a;

						if (b > c)
						{
							first = b;
							second = c;
						}
						else
						{
							first = c;
							second = b;
						}
					}
				}

				Console.WriteLine ("{0} {1} {2}", first, second, third);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
