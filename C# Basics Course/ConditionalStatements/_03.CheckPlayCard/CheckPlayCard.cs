using System;

namespace _03.CheckPlayCard
{
	class CheckPlayCard
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a symbol to check if it is a card!");

			try
			{
				string symbol = Console.ReadLine();

				switch (symbol)
				{
					case "2":
					case "3":
					case "4":
					case "5":
					case "6":
					case "7":
					case "8":
					case "9":
					case "10":
					case "J":
					case "Q":
					case "K":
					case "A":
					Console.WriteLine ("Result: yes");
					break;

					default:
					Console.WriteLine ("Result: no");
					break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
