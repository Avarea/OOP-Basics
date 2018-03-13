using System;

public abstract class Provider : Machine
{
    private double energyOutput;

    public double EnergyOutput
    {
        get => energyOutput;
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput) : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public override string ToString()
    {
        return $"{Type} Provider - {Id}" + Environment.NewLine +
               $"Energy Output: {energyOutput}";
    }
}

