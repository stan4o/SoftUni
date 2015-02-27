using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.ZeroSubset
{
	class ZeroSubset
	{
		public static void Main()
		{
			// 3 -2 1 1 8
			// 3 1 -7 35 22
			// 1 3 -4 -2 -1
			// 1 1 1 -1 -1
			// 0 0 0 0 0

			Console.WriteLine("Enter sequence of 5 integers separated by a space e.g \"1 2 3 4 5\"!");
			bool isFound = false;

			try
			{
				string[] input = Console.ReadLine().Split(' ');
				int inputLength = input.Length;

				// There will be 2^N subsets for a given set (5 numbers = 2^5 = 32 subsets)
				int subsetsCount = (int)Math.Pow(2, inputLength);
				for (int j = 0; j < subsetsCount; j++)
				{
					var subset = new List<int>();
					for (int bit = 0; bit < inputLength; bit++)
					{
						if (GetBit(j, bit) == 1)
						{
							int currNum = Convert.ToInt32(Convert.ToString(input[bit]));
							subset.Add(currNum);
						}
					}

					if ((subset.Count >= 2) && (subset.Sum() == 0))
					{
						Console.WriteLine (new String('-', 20));
						Console.WriteLine (string.Join(" + ", subset) + " = 0");
						isFound = true;
					}
				}

				if (!isFound)
				{
					Console.WriteLine (new String('-', 20));
					Console.WriteLine ("no zero subset");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		// Get the bit at certain position
		public static int GetBit(int value, int position)
		{
		    int bit = value & (int)Math.Pow(2, position);
		    return (bit > 0 ? 1 : 0);
		}
	}
}
