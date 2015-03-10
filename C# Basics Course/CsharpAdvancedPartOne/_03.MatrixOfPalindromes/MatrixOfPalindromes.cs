using System;

namespace _03.MatrixOfPalindromes
{
	class MatrixOfPalindromes
	{
		public static void Main()
		{
			Console.WriteLine("Enter 2 digits separated by space for the matrix!");

			try
			{
				string[] input = Console.ReadLine().Split(' ');
				int height = int.Parse(input[0]);
				int width = int.Parse(input[1]);
				var matrix = new string[height, width];

				for (int h = 0; h < height; h++)
				{
					for (int w = 0; w < width; w++)
					{
						matrix[h,w] = "" + (char)('a' + h) + (char)('a' + (w + h)) + (char)('a' + h);
					}
				}

				for (int r = 0; r < height; r++)
				{
					for (int c = 0; c < width; c++)
					{
						Console.Write(matrix[r,c] + " ");
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
