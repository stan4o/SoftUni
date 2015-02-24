using System;

namespace _11.NumberAsWords
{
	class NumberAsWords
	{
		public static void Main()
		{
			Console.WriteLine("Enter a digit!");
			string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			try
			{
				int d;
				string result = "";

				if (int.TryParse(Console.ReadLine(), out d))
				{
					if (0 <= d && d < 10)
					{
						result = ones[d];
					}
					else if (10 <= d && d < 20)
					{
						result = teens[d % 10];
					}
					else if (20 <= d && d < 100)
					{
						if (d % 10 == 0)
						{
							result = tens[d / 10];
						}
						else
						{
							result = tens[d / 10] + "-" + ones[d % 10];
						}
					}
					else if (100 <= d && d < 1000)
					{
						if (d % 100 == 0)
						{
							result = ones[d / 100] + " hundred";
						}
						else
						{
							if (0 < (d % 100) && (d % 100) < 10)
							{
								result = ones[d / 100] + " hundred and " + ones[d % 100];
							}
							else if (10 <= (d % 100) && (d % 100) < 20)
							{
								result = ones[d / 100] + " hundred and " + teens[(d % 100) % 10];
							}
							else if ((d % 100) % 10 == 0)
							{
								result = ones[d / 100] + " hundred and " + tens[(d % 100) / 10];
							}
							else
							{
								result = ones[d / 100] + " hundred and " + tens[(d % 100) / 10] + "-" + ones[(d % 100) % 10];
							}
						}
					}
					else
					{
						throw new Exception("Digit out of range (0 <= digit <= 999)!");
					}
				}
				else
				{
					throw new Exception("Please enter a valid digit!");
				}

				Console.WriteLine (Environment.NewLine + "Number as word: " + result);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
