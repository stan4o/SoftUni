using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int n = 5;
        int p = 2;
        Console.WriteLine("Is the bit at position {1} in the integer {0} equal to 1 {2}", n, p, ((n >> p) & 1) == 1);

        n = 0;
        p = 9;
        Console.WriteLine("Is the bit at position {1} in the integer {0} equal to 1 {2}", n, p, ((n >> p) & 1) == 1);

        n = 15;
        p = 1;
        Console.WriteLine("Is the bit at position {1} in the integer {0} equal to 1 {2}", n, p, ((n >> p) & 1) == 1);

        n = 5343;
        p = 7;
        Console.WriteLine("Is the bit at position {1} in the integer {0} equal to 1 {2}", n, p, ((n >> p) & 1) == 1);

        n = 62241;
        p = 11;
        Console.WriteLine("Is the bit at position {1} in the integer {0} equal to 1 {2}", n, p, ((n >> p) & 1) == 1);
    }
}