using System;

public abstract class Harvester : Machine
{
    private double oreOutput;
    private double energyRequirement;

    public double OreOutput
    {
        get => oreOutput;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get => energyRequirement;
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    protected Harvester(string id, double oreOutput, double energyRequirement) : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public override string ToString()
    {
        return $"{Type} Harvester - {Id}" + Environment.NewLine + 
               $"Ore Output: {OreOutput}" + Environment.NewLine +
               $"Energy Requirement: {EnergyRequirement}";
    }
}

