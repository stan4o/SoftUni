using System;

namespace _08.DigitAsWord
{
	class DigitAsWord
	{
		public static void Main()
		{
			Console.WriteLine ("Enter a digit to see it's string representation!");

			try
			{
				int number = int.Parse(Console.ReadLine());
				string output;

				switch (number)
				{
					case 0:
						output = "Zero";
						break;
					case 1:
						output = "One";
						break;
					case 2:
						output = "Two";
						break;
					case 3:
						output = "Three";
						break;
					case 4:
						output = "Four";
						break;
					case 5:
						output = "Five";
						break;
					case 6:
						output = "Six";
						break;
					case 7:
						output = "Seven";
						break;
					case 8:
						output = "Eight";
						break;
					case 9:
						output = "Nine";
						break;

					default:
						output = "not a digit";
						break;
				}

				Console.WriteLine (output);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
