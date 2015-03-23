using System;

namespace FunWithMatrices
{
	class FunWithMatrices
	{
		public static void Main()
		{

			double startValue = double.Parse(Console.ReadLine());
			double step = double.Parse(Console.ReadLine());
			int m = 4;
			var matrix = new double[m, m];

			for (int r = 0; r < m; r++)
			{
				for (int c = 0; c < m; c++)
				{
					matrix[r, c] = (r == 0 && c == 0) ? startValue : startValue += step;
				}
			}

			while (true)
			{
				string command = Console.ReadLine();

				if (command != "Game Over!")
				{
					string[] commands = command.Split(' ');
					int row = int.Parse(commands[0]);
					int col = int.Parse(commands[1]);
					string operation = commands[2];
					double number = double.Parse(commands[3]);

					if (operation == "multiply")
					{
						matrix[row, col] *= number;
					}
					else if (operation == "sum")
					{
						matrix[row, col] += number;
					}
					else
					{
						matrix[row, col] = Math.Pow(matrix[row, col], number);
					}

				}
				else
				{
					break;
				}
			}

			int brsRow = 0;
			double biggestRowSum = double.MinValue;
			int bcsCol = 0;
			double biggestColSum = double.MinValue;
			double leftDiagonal = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
			double rightDiagonal = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];

			for (int r = 0; r < m; r++)
			{
				double currRowSum = 0;
				double currColSum = 0;

				for (int c = 0; c < m; c++)
				{
					currRowSum += matrix[r, c];
					currColSum += matrix[c, r];
				}

				if (currRowSum > biggestRowSum)
				{
					biggestRowSum = currRowSum;
					brsRow = r;
				}

				if (currColSum > biggestColSum)
				{
					biggestColSum = currColSum;
					bcsCol = r;
				}
			}

			if (biggestRowSum >= biggestColSum)
			{
				if (leftDiagonal >= rightDiagonal)
				{
					if (biggestRowSum >= leftDiagonal)
					{
						Console.WriteLine("ROW[{0}] = {1:F2}", brsRow, biggestRowSum);
					}
					else
					{
						Console.WriteLine("LEFT-DIAGONAL = {0:F2}", leftDiagonal);
					}
				}
				else
				{
					if (biggestRowSum >= rightDiagonal)
					{
						Console.WriteLine("ROW[{0}] = {1:F2}", brsRow, biggestRowSum);
					}
					else
					{
						Console.WriteLine("RIGHT-DIAGONAL = {0:F2}", rightDiagonal);
					}
				}
			}
			else
			{
				if (leftDiagonal >= rightDiagonal)
				{
					if (biggestColSum >= leftDiagonal)
					{
						Console.WriteLine("COLUMN[{0}] = {1:F2}", bcsCol, biggestColSum);
					}
					else
					{
						Console.WriteLine("LEFT-DIAGONAL = {0:F2}", leftDiagonal);
					}
				}
				else
				{
					if (biggestColSum >= rightDiagonal)
					{
						Console.WriteLine("COLUMN[{0}] = {1:F2}", bcsCol, biggestColSum);
					}
					else
					{
						Console.WriteLine("RIGHT-DIAGONAL = {0:F2}", rightDiagonal);
					}
				}
			}
		}
	}
}