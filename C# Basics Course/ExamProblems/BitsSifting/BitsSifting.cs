using System;

namespace BitsSifting
{
	class BitsSifting
	{
		public static void Main()
		{
			ulong number = ulong.Parse(Console.ReadLine());
			int numberOfIntegers = int.Parse(Console.ReadLine());
			int result = 0;
			ulong one = 1L;

			for (int i = 0; i < numberOfIntegers; i++)
			{
				ulong sieve = ulong.Parse(Console.ReadLine());
				for (int j = 0; j < 64; j++)
				{
					ulong mask = one << j;
					ulong sieveAtPosition = sieve & mask;

					if (sieveAtPosition > 0)
					{
						number = number & ~mask;
					}

				}
			}

			for (int k = 0; k < 64; k++)
			{
				ulong mask = one << k;
				ulong bit = number & mask;

				if (bit > 0)
				{
					result++;
				}

			}

			Console.WriteLine(result);
		}
	}
}

//	10100101
//	↓ ↓  ↓ ↓
//	10001010
//	↓  ↓ ↓
//	01010100
//	↓    ↓
//	10011010
//	↓    ↓
//	00100001