using System;

namespace TheExplorer
{
	class TheExplorer
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine ());

			Console.Write (new string ('-', n / 2));
			Console.Write ('*');
			Console.Write (new string ('-', n / 2) + "\n");

			// upper part
			int max = n / 2;
			for (int i = 1; i <= max; i++) {
				Console.Write (new string ('-', (n / 2) - i));
				Console.Write ('*');
				Console.Write (new string ('-', (2 * i) - 1));
				Console.Write ('*');
				Console.Write (new string ('-', (n / 2) - i) + "\n");
			}

			// lower part
			for (int i = n / 2 - 1; i >= 1; i--) {
				Console.Write (new string ('-', (n / 2) - i));
				Console.Write ('*');
				Console.Write (new string ('-', (2 * i) - 1));
				Console.Write ('*');
				Console.Write (new string ('-', (n / 2) - i) + "\n");
			}

			Console.Write (new string ('-', n / 2));
			Console.Write ('*');
			Console.Write (new string ('-', n / 2));
		}
	}
}
