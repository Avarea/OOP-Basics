using System;

public class Car : IVehicle
{
    private double additionalConsumption = 0.9;
    public double fuelQuantity { get; private set; }
    public double fuelConsumptionPerKm { get; }

    public Car(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public string Drive(double kilometers)
    {
        double fuelNeeded = (this.fuelConsumptionPerKm + additionalConsumption) * kilometers;
        if (fuelNeeded < this.fuelQuantity)
        {
            this.fuelQuantity -= fuelNeeded;
            return $"Car travelled {kilometers} km";
        }
        else
        {
            return "Car needs refueling";
        }
    }

    public void Refuel(double liters)
    {
        this.fuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"Car: {this.fuelQuantity:f2}";
    }
}

