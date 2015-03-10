using System;

namespace _04.PrintDeckOfCards
{
	class PrintDeckOfCards
	{
		public static void Main()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			char spade = (char)9824;
			char heart = (char)9829;
			char diamond = (char)9830;
			char club = (char)9827;
			var cardSuits = new char[] { spade, heart, diamond, club };

			for (int i = 2; i <= 14; i++)
			{
				for (int k = 0; k < cardSuits.Length; k++)
				{
					switch (i)
					{
						case 11:
							Console.Write("{0}{1} ", 'J', cardSuits[k]);
							break;

						case 12:
							Console.Write("{0}{1} ", 'Q', cardSuits[k]);
							break;

						case 13:
							Console.Write("{0}{1} ", 'K', cardSuits[k]);
							break;

						case 14:
							Console.Write("{0}{1} ", 'A', cardSuits[k]);
							break;

						default:
							Console.Write("{0}{1} ", i, cardSuits[k]);
							break;
					}
				}

				Console.WriteLine("\r\n");
			}
		}
	}
}
