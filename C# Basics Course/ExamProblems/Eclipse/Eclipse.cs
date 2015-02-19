using System;

namespace Eclipse
{
	class Eclipse
	{
		public static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			// top
			PrintTopBottomPart(n);

			// middle
			PrintMiddlePart(n);

			// bottom
			PrintTopBottomPart(n);
		}

		public static void PrintTopBottomPart (int number)
		{
			string border = new string('*', (number * 2) - 2);
			string space = new string(' ', number - 1);
			Console.WriteLine(" {0} {1} {0} ", border, space);
		}

		public static void PrintMiddlePart (int number)
		{
			string middlePart = new string('/', (number * 2) - 2);

			for (int i = 1; i <= number - 2; i++)
			{
				string space = (i == (number / 2)) ? new string('-', number - 1) : new string(' ', number - 1);

				Console.WriteLine("*{0}*{1}*{0}*", middlePart, space);
			}
		}
	}
}
