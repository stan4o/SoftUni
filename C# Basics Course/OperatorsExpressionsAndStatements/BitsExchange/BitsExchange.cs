using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Choose integer! Must less than {0} !", UInt32.MaxValue);
        uint n = uint.Parse(Console.ReadLine());
        uint firstBits = (n >> 3) & 7; // get 3,4,5 bits
        uint secondBits = (n >> 24) & 7; // get 24,25,26 bits
        uint maskFirst = 7 << 3; // mask for the 3,4,5 bits
        uint maskSecond = 7 << 24; // mask for the 24,25,26 bits

        n = n & ~maskFirst | (secondBits << 3); // turn 3,4,5 to 0 and XOR them with 24,25,26
        n = n & ~maskSecond | (firstBits << 24); // turn 24,25,26 to 0 and XOR them with 3,4,5

        Console.WriteLine("Result -> {0}", n);
    }
}