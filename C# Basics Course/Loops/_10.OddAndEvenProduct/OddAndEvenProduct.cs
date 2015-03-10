using System;

namespace _10.OddAndEvenProduct
{
	class OddAndEvenProduct
	{
		public static void Main()
		{
			Console.WriteLine("Enter sequence of digits!");

			try
			{
				string input = Console.ReadLine();
				string[] digitsAsString = input.Split(' ');
				int oddProduct = 1;
				int evenProduct = 1;

				for (int i = 0; i < digitsAsString.Length; i++)
				{
					int currentNumber = int.Parse(digitsAsString[i]);

					if ((i + 1) % 2 == 0)
					{
						evenProduct *= currentNumber;
					}
					else
					{
						oddProduct *= currentNumber;
					}
				}

				if (evenProduct == oddProduct)
				{
					Console.WriteLine ("Yes");
					Console.WriteLine ("product = " + evenProduct);
				}
				else
				{
					Console.WriteLine ("No");
					Console.WriteLine ("odd_product = " + oddProduct);
					Console.WriteLine ("even_product = " + evenProduct);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
