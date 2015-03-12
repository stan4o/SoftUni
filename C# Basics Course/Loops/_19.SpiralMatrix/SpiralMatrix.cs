using System;

namespace _19.SpiralMatrix
{
	class SpiralMatrix
	{
		public static void Main()
		{
			Console.WriteLine("Enter number for the spiral matrix!");

			try
			{
				int n = int.Parse(Console.ReadLine());
				var matrix = new int[n,n];
				int maxIndex = n * n;
				int index = 1;
				int row = 0;
				int col = 0;

				while (index <= maxIndex)
				{
					while ((col <= n - 1) && matrix[row,col] == 0)
					{
						matrix[row,col] = index;
						index++;
						col++;
					}

					row++;
					col--;

					while ((row <= n - 1) && matrix[row,col] == 0)
					{
						matrix[row,col] = index;
						index++;
						row++;
					}

					row--;
					col--;

					while ((col >= 0) && matrix[row,col] == 0)
					{
						matrix[row,col] = index;
						index++;
						col--;
					}

					row--;
					col++;

					while ((row >= 0) && matrix[row,col] == 0)
					{
						matrix[row,col] = index;
						index++;
						row--;
					}

					row++;
					col++;
				}

				for (int r = 0; r < n; r++)
				{
					for (int c = 0; c < n; c++)
					{
						Console.Write("{0,4}", matrix[r, c]);
					}

					Console.Write(Environment.NewLine);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
