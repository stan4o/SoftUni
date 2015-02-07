using System;

class ExchangeVariableValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;

        Console.WriteLine("Before exchange: a = {0} b = {1}", a, b);

        byte c = a; // temporary variable
        a = b;
        b = c;

        Console.WriteLine("Before exchange: a = {0} b = {1}", a, b);
    }
}
