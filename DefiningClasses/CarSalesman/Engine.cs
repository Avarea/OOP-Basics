using System;

public class Engine
{
    public string Model { get; set; }
    public double Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, double power)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = "n/a";
        this.Efficiency = "n/a";
    }

    public Engine(string model, double power, string optional):this(model, power)
    {
        if (double.TryParse(optional, out double displacement))
        {
            this.Displacement = displacement.ToString();
        }
        else
        {
            this.Efficiency = optional;
        }
    }

    public Engine(string model, double power, string displacement, string efficiency):this(model,power)
    {
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public override string ToString()
    {
        return $"    Displacement: {Displacement}{Environment.NewLine}" +
               $"    Efficiency: {Efficiency}{Environment.NewLine}";
    }
}

