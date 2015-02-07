using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        double plays = 0.0d;
        int weekends = 52;
        char leapYear = char.Parse(Console.ReadLine());
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int normalWeekends = weekends - hometownWeekends;

        plays += holidays * 1d / 2d; // holiday plays
        plays += normalWeekends * 2d / 3d; // normal weekend plays
        plays += hometownWeekends; // hometown weekend plays

        if (leapYear == 't')
        {
            plays += 3;
        }

        Console.Write(Math.Floor(plays));
    }
}
