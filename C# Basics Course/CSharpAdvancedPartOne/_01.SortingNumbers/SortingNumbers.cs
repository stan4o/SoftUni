using System;

namespace _01.SortingNumbers
{
	class SortingNumbers
	{
		public static void Main()
		{
			Console.WriteLine("Enter length for sequence!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				var numbers = new int[n];

				for (int i = 0; i < n; i++)
				{
					numbers[i] = int.Parse(Console.ReadLine());
				}

				Array.Sort(numbers);

				Console.WriteLine (string.Join(" ", numbers));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
