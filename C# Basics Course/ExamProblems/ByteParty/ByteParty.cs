using System;

namespace ByteParty
{
	class ByteParty
	{
		public static void Main()
		{
			int count = int.Parse(Console.ReadLine());
			var numbers = new int[count];

			for (int i = 0; i < count; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			while (true)
			{
				string command = Console.ReadLine();

				if (command != "party over")
				{
					string[] commands = command.Split(' ');
					int type = int.Parse(commands[0]);
					int pos = int.Parse(commands[1]);
					int mask = 1 << pos;

					for (int i = 0; i < count; i++)
					{
						if (type < 0)
						{
							numbers[i] = numbers[i] ^ mask;
						}
						else if (type > 0)
						{
							numbers[i] = numbers[i] | mask;
						}
						else
						{
							numbers[i] = numbers[i] & ~mask;
						}
					}
				}
				else
				{
					break;
				}
			}

			foreach (var number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}