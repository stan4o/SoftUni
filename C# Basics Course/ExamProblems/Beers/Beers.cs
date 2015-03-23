using System;

namespace Beers
{
	class Beers
	{
		public static void Main()
		{
			string command = Console.ReadLine();
			int stacks = 0;
			int beers = 0;

			do
			{

				string[] commands = command.Split(' ');
				int count = int.Parse(commands[0]);
				string type = commands[1];

				if (type == "beers")
				{
					beers += count;
				}
				else
				{
					stacks += count;
				}

				command = Console.ReadLine();
			}
			while (command != "End");

			if (beers > 19)
			{
				stacks += beers / 20;
				beers %= 20;
			}

			Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
		}
	}
}