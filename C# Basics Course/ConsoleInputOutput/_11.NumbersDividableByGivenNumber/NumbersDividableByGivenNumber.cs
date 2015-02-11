using System;

namespace _11.NumbersDividableByGivenNumber
{
	class NumbersDividableByGivenNumber
	{
		public static void Main ()
		{
			Console.WriteLine ("Enter start number (must be an integer)!");

			try
			{
				int start = int.Parse (Console.ReadLine ());
				if (start % 1 != 0) throw new Exception ();

				Console.WriteLine ("Enter end number (must be an integer)!");
				int end = int.Parse (Console.ReadLine ());
				if (end % 1 != 0) throw new Exception ();

				int p = 0;
				string result = "";

				for (int i = start; i <= end; i++)
				{
					if (i % 5 == 0)
					{
						result += i + " ";
						p++;
					}
				}

				if (p == 0)
				{
					result = "-";
				}

				Console.WriteLine ("{0} digits: {1}", p, result);
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);	
			}
		}
	}
}
