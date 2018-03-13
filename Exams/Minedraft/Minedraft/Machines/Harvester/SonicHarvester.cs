public class SonicHarvester : Harvester
{
    private int sonicFactor;
    public override string Type => "Sonic";

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id,oreOutput,energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / sonicFactor;
    }
}

