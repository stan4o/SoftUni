using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        byte decimalNumber = 254;
        string hexaDecimalNumber = decimalNumber.ToString("X");
        Console.WriteLine("The number {0} in hexadecimal format is: 0x{1}", decimalNumber, hexaDecimalNumber);
    }
}