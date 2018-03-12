using System;

class Startup
{
    static void Main()
    {
        string driverName = Console.ReadLine();
        ICar car = new Ferarri(driverName);
        Console.WriteLine(car);
    }
}

