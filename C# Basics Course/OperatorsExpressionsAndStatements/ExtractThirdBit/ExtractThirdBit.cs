using System;

class ExtractThirdBit
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Third bit of {0} is {1}", n, (n >> 3) & 1);

        n = 0;
        Console.WriteLine("Third bit of {0} is {1}", n, (n >> 3) & 1);

        n = 15;
        Console.WriteLine("Third bit of {0} is {1}", n, (n >> 3) & 1);

        n = 5343;
        Console.WriteLine("Third bit of {0} is {1}", n, (n >> 3) & 1);

        n = 62241;
        Console.WriteLine("Third bit of {0} is {1}", n, (n >> 3) & 1);
    }
}