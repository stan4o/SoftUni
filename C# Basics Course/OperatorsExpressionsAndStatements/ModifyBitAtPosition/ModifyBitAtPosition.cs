using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Choose integer! Must less than {0} !", Int32.MaxValue);
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose value of bit! Must be 1 or 0");
        byte v = byte.Parse(Console.ReadLine());
        Console.WriteLine("Choose position to change bit! Must be <= 32 !");
        byte p = byte.Parse(Console.ReadLine());

        if (v == 0)
        {
            n = n & (~(1 << p));
        }
        else
        {
            n = n | (1 << p);
        }

        Console.WriteLine("The result is {0}", n);
    }
}