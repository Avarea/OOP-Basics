using System;

public abstract class Car
{
    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfProduction { get; set; }
    public int Horsepower { get; set; }
    public int Acceleration { get; set; }
    public int Suspension { get; set; }
    public int Durability { get; set; }

    public override string ToString()
    {
        return $"{this.Brand} {this.Model} {this.YearOfProduction}" + Environment.NewLine +
               $"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s" + Environment.NewLine +
               $"{this.Suspension} Suspension force, {this.Durability} Durability";
    }

    public int GetOverallPerformance()
    {
        return (this.Horsepower / this.Acceleration) + (this.Suspension + this.Durability);
    }

    public int GetEnginePerformance()
    {
        return (this.Horsepower / this.Acceleration);
    }

    public int GetSuspensionPerformance()
    {
        return (this.Suspension + this.Durability);
    }

    public int OverallPerformance()
    {
        var calculateOverallPerformance = (this.Horsepower / this.Acceleration) + (this.Suspension + this.Durability);
        return calculateOverallPerformance;
    }

    public int EnginePerformance()
    {
        var calculateEnginePerformance = this.Horsepower / this.Acceleration;
        return calculateEnginePerformance;
    }

    public int SuspensionPerformance()
    {
        var calculateSuspensionPerformance = this.Suspension + this.Durability;
        return calculateSuspensionPerformance;
    }
}


