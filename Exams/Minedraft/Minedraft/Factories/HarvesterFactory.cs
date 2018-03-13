using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester CreateHarvester(List<string> argument)
    {
        var type = argument[0];
        var id = argument[1];
        double oreOutput = double.Parse(argument[2]);
        double energyRequirment = double.Parse(argument[3]);

        switch (type)
        {
            case "Sonic":
                return new SonicHarvester(id, oreOutput, energyRequirment, int.Parse(argument[4]));
            case "Hammer":
                return new HammerHarvester(id,oreOutput, energyRequirment);
                default:
                    throw new ArgumentException();
        }
    }
}

