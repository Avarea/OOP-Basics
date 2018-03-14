using System;
using System.Collections.Generic;

public class DriverFactory
{
    public static Driver CreateDriver(List<string> argument, Car car)
    {
        var type = argument[0];
        var name = argument[1];

        switch (type)
        {
            case "Aggressive":
                return new AggressiveDriver(name, car);
            case "Endurance":
                return new EnduranceDriver(name,car);
                default:
                    throw new ArgumentException();
        }
    }
}

