using System;

class MoonGravitation
{
    static void Main()
    {
        double weightOnEarth = 86d;
        Console.WriteLine("Weight on the Earth -> {0} and weight on the Moon {1}.", weightOnEarth, weightOnEarth * 17d / 100d);

        weightOnEarth = 74.6d;
        Console.WriteLine("Weight on the Earth -> {0} and weight on the Moon {1}.", weightOnEarth, weightOnEarth * 17d / 100d);

        weightOnEarth = 53.7d;
        Console.WriteLine("Weight on the Earth -> {0} and weight on the Moon {1}.", weightOnEarth, weightOnEarth * 17d / 100d);
    }
}