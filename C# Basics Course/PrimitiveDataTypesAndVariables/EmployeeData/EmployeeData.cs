using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Stanimir";
        string lastName = "Panayotov";
        byte age = 26;
        char gender = 'm';
        ulong PIDN = 8306112507;
        uint UEN = 27560000;

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", PIDN);
        Console.WriteLine("Unique employee number: {0}", UEN);
    }
}
