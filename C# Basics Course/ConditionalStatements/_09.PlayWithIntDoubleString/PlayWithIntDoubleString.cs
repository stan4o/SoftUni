using System;

namespace _09.PlayWithIntDoubleString
{
	class PlayWithIntDoubleString
	{
		public static void Main()
		{
			Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");

			try
			{
				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.WriteLine ("Please enter a int!");
						int userInt = int.Parse(Console.ReadLine());
						userInt++;
						Console.WriteLine ("Result: " + userInt);
						break;

					case 2:
						Console.WriteLine ("Please enter a double!");
						double userDouble = double.Parse(Console.ReadLine());
						userDouble++;
						Console.WriteLine ("Result: " + userDouble);
						break;
					
					case 3:
						Console.WriteLine ("Please enter a string!");
						string userString = Console.ReadLine();
						Console.WriteLine ("Result: " + userString + "*");
						break;

					default:
						Console.WriteLine ("Wrong choice! Please try again!");
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
