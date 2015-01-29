using System;

class StringsAndObjects
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World";
        object objVariable = helloString + " " + worldString;
        string finalString = (string)objVariable;

        Console.WriteLine(objVariable);
        Console.WriteLine(finalString);
    }
}
