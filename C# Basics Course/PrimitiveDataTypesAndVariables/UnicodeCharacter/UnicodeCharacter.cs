using System;
using System.Text;

class UnicodeCharacter
{
    static void Main()
    {
        byte decimalNumber = 42;
        char unicodeChar = (char)decimalNumber;

        Console.WriteLine("The unicode character of the number code {0} is : {1}", decimalNumber, unicodeChar);
    }
}
