using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = 5;
        int p = 2;
        Console.WriteLine("The bit at position {1} in the integer {0} is {2}", n, p, (n >> p) & 1);

        n = 0;
        p = 9;
        Console.WriteLine("The bit at position {1} in the integer {0} is {2}", n, p, (n >> p) & 1);

        n = 15;
        p = 1;
        Console.WriteLine("The bit at position {1} in the integer {0} is {2}", n, p, (n >> p) & 1);

        n = 5343;
        p = 7;
        Console.WriteLine("The bit at position {1} in the integer {0} is {2}", n, p, (n >> p) & 1);

        n = 62241;
        p = 11;
        Console.WriteLine("The bit at position {1} in the integer {0} is {2}", n, p, (n >> p) & 1);
    }
}