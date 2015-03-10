using System;

namespace _15.HexadecimalToDecimal
{
	class HexadecimalToDecimal
	{
		public static void Main()
		{
			Console.WriteLine("Enter hexadecimal number to convert to decimal number!");

			try
			{
				string hex = Console.ReadLine();
				long result = 0;

				for (int i = hex.Length - 1; i >= 0; i--)
				{
					switch (hex[i])
					{
						case 'A':
							result += (long)(10 * Math.Pow(16, (hex.Length - 1) - i));
							break;

						case 'B':
							result += (long)(11 * Math.Pow(16, (hex.Length - 1) - i));
							break;
						
						case 'C':
							result += (long)(12 * Math.Pow(16, (hex.Length - 1) - i));
							break;
						
						case 'D':
							result += (long)(13 * Math.Pow(16, (hex.Length - 1) - i));
							break;

						case 'E':
							result += (long)(14 * Math.Pow(16, (hex.Length - 1) - i));
							break;

						case 'F':
							result += (long)(15 * Math.Pow(16, (hex.Length - 1) - i));
							break;
						
						default:
							int n = int.Parse(Convert.ToString(hex[i]));
							result += (long)(n * Math.Pow(16, (hex.Length - 1) - i));
							break;
					}
				}

				Console.WriteLine (result);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
