using System;

namespace _11.RandomNumbersInGivenRange
{
	class RandomNumbersInGivenRange
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for N!");
			Random random = new Random();

			try
			{
				int n = int.Parse(Console.ReadLine());
				Console.WriteLine ("Enter value for min");
				int min = int.Parse(Console.ReadLine());
				Console.WriteLine ("Enter value for max");
				int max = int.Parse(Console.ReadLine());

				Console.WriteLine (new String('-', 20));
				for (int i = 0; i < n; i++)
				{
					Console.Write(random.Next(min, max) + " ");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
