using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public Provider CreateProvider(List<string> argument)
    {
        var type = argument[0];
        var id = argument[1];
        var energyOutput = double.Parse(argument[2]);

        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);
            case "Pressure":
                return new PressureProvider(id, energyOutput);
            default:
                throw new ArgumentException();
        }
    }
}

