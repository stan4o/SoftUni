using System;

namespace _13.BinaryToDecimal
{
	class BinaryToDecimal
	{
		public static void Main()
		{
			Console.WriteLine("Enter binary integer to convert to decimal!");

			try
			{
				string binary = Console.ReadLine();
				double decimalNumber = 0;

				for (int i = binary.Length - 1; i >= 0; i--)
				{
					if (binary[i] == '1')
					{
						decimalNumber += 1 * Math.Pow(2, (binary.Length -1) - i);
					}
				}

				Console.WriteLine ("Decimal representation: " + decimalNumber);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
