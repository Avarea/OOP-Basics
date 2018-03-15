using System;
using System.Collections.Generic;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Addons = new List<string>();
        this.Horsepower += horsepower * 50 / 100;
        this.Suspension -= suspension * 25 / 100;
    }

    public List<string> Addons { get; set; }

    public override string ToString()
    {
        if (Addons.Count == 0)
        {
            return base.ToString() + Environment.NewLine + "Add-ons: None";
        }

        return base.ToString() + Environment.NewLine +
               $"Add-ons: {String.Join(", ", this.Addons)}";
    }
}

