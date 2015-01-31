using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char bridge, lens;
        int middle = (int) Math.Floor(n / 2d);

        for (int i = 0; i < n; i++)
        {
            if (i == middle)
            {
                bridge = '|';
            }
            else
            {
                bridge = ' ';
            }

            if (i != 0 && i != n - 1)
            {
                lens = '/';
            }
            else
            {
                lens = '*';
            }

            Console.Write('*');
            Console.Write(new string(lens, 2 * n - 2));
            Console.Write('*');
            Console.Write(new string(bridge, n));
            Console.Write('*');
            Console.Write(new string(lens, 2 * n - 2));
            Console.Write('*');
            Console.Write('\n');
        }
    }
}