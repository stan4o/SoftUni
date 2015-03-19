using System;
using System.Collections.Generic;

namespace MagicStrings
{
	class MagicStrings
	{
		public static void Main()
		{
			int diff = int.Parse(Console.ReadLine());
			bool isFound = false;
			char[] chars = { 's', 'n', 'k', 'p' };
			int[] weights = { 3, 4, 1, 5 };
			var finalStrings = new List<string>();

			int length = chars.Length;

			for (int i1 = 0; i1 < length; i1++)
			{
				for (int i2 = 0; i2 < length; i2++)
				{
					for (int i3 = 0; i3 < length; i3++)
					{
						for (int i4 = 0; i4 < length; i4++)
						{
							for (int i5 = 0; i5 < length; i5++)
							{
								for (int i6 = 0; i6 < length; i6++)
								{
									for (int i7 = 0; i7 < length; i7++)
									{
										for (int i8 = 0; i8 < length; i8++)
										{
											int firstSum = weights[i1] + weights[i2] + weights[i3] + weights[i4];
											int secondSum = weights[i5] + weights[i6] + weights[i7] + weights[i8];
											int difference = Math.Abs(firstSum - secondSum);

											if (difference == diff)
											{
												string finalString = "" + chars[i1] + chars[i2] + chars[i3] + chars[i4] + chars[i5] + chars[i6] + chars[i7] + chars[i8];
												finalStrings.Add(finalString);
												isFound = true;
											}

										}
									}
								}
							}
						}
					}
				}
			}

			if (!isFound)
			{
				Console.WriteLine("No");
			}
			else
			{
				finalStrings.Sort();
				foreach (var final in finalStrings)
				{
					Console.WriteLine(final);
				}
			}

		}
	}
}