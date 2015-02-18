using System;

namespace BitsInverter
{
	class MainClass
	{
		public static void Main()
		{
			int numberOfBytes = int.Parse (Console.ReadLine ());
			int step = int.Parse (Console.ReadLine ());
			int index = 0;

			for (int i = 0; i < numberOfBytes; i++)
			{
				int currentByte = int.Parse (Console.ReadLine ());

				for (int p = 7; p >= 0; p--)
				{
					if ((index % step == 0) || step == 1)
					{
						currentByte = currentByte ^ (1 << p);
					}

					index++;
				}

				Console.WriteLine(currentByte);
			}
		}
	}
}