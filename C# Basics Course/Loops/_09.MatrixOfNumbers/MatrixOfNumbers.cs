using System;

namespace _09.MatrixOfNumbers
{
	class MatrixOfNumbers
	{
		public static void Main()
		{
			Console.WriteLine("Enter value for matrix!");

			try
			{
				int matrix = int.Parse(Console.ReadLine());

				for (int i = 0; i < matrix; i++)
				{
					for (int k = 1; k <= matrix; k++)
					{
						Console.Write((k + i) + " ");
					}

					Console.WriteLine ();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
