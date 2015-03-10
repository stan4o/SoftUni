using System;

namespace _14.DecimalToBinary
{
	class DecimalToBinary
	{
		public static void Main()
		{
			Console.WriteLine("Enter decimal number to convert to binary representation!");

			try
			{
				long decimalNumber = long.Parse(Console.ReadLine());
				string binary = "";

				while (decimalNumber / 2 != 0)
				{
					if (decimalNumber % 2 == 1)
					{
						binary = "1" + binary;
					}
					else
					{
						binary = "0" + binary;
					}

					decimalNumber = decimalNumber / 2;
				}

				Console.WriteLine (binary);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
