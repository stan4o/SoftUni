using System;

namespace _16.DecimalToHexadecimal
{
	class DecimalToHexadecimal
	{
		public static void Main()
		{
			Console.WriteLine("Enter decimal number to convert to hexadecimal!");

			try
			{
				long decimalNumber = long.Parse(Console.ReadLine());
				string hex = "";

				while (decimalNumber % 16 != 0)
				{
					switch (decimalNumber % 16)
					{
						case 10:
							hex = "A" + hex;
							break;

						case 11:
							hex = "B" + hex;
							break;

						case 12:
							hex = "C" + hex;
							break;

						case 13:
							hex = "D" + hex;
							break;

						case 14:
							hex = "E" + hex;
							break;

						case 15:
							hex = "F" + hex;
							break;

						default:
							hex = string.Concat(decimalNumber % 16) + hex;
						break;
					}

					decimalNumber = decimalNumber / 16;
				}

				Console.WriteLine (hex);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
