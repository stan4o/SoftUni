using System;

namespace _12.RandomizeTheNumbers
{
	class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for N!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				int[] arrayOfNumbers = new int[n];
				Random r = new Random();

				// fill the array
				for (int l = 0; l < arrayOfNumbers.Length; l++)
				{
					arrayOfNumbers[l] = l + 1;
				}

				// swap values
				for (int i = arrayOfNumbers.Length; i > 1; i--)
				{
					int j = r.Next(i);
					int tmp = arrayOfNumbers[j];
					arrayOfNumbers[j] = arrayOfNumbers[i - 1];
					arrayOfNumbers[i - 1] = tmp;
				}

				// Print new arrays
				Console.WriteLine (string.Join(" ", arrayOfNumbers));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
