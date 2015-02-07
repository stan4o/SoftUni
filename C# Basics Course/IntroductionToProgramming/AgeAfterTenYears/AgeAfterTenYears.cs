using System;

class AgeAfterTenYears
{
    static void Main()
    {
        int year = DateTime.Now.Year;
        string birthday = Console.ReadLine();
        string[] birthdayArr = birthday.Split('.');
        int birthYear = Convert.ToInt32(birthdayArr[2]);
        int age = year - birthYear;

        Console.WriteLine("Enter your birthday! E.g DD.MM.YYYY");
        Console.WriteLine("You are " + Convert.ToString(age) + " old.");
        Console.WriteLine("You will be " + Convert.ToString(age + 10) + " after 10 years.");
    }
}
