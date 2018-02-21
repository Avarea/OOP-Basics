using System;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumption;
    private decimal distanceTraveled;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public decimal FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public decimal FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public decimal DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraveled = 0;
    }

    public void Move(decimal amountKm)
    {
        decimal fuelNeeded = FuelConsumption * amountKm;
        if (fuelNeeded <= FuelAmount)
        {
            FuelAmount -= fuelNeeded;
            DistanceTraveled += amountKm;
        }
        else
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {DistanceTraveled}";
    }
}
