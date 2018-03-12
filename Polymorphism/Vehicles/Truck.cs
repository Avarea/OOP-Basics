using System;

public class Truck : IVehicle
{
    private double additionalConsumption = 1.6;

    public double fuelQuantity { get; private set; }
    public double fuelConsumptionPerKm { get; }

    public Truck(double fuelQuantity, double fuelConsumptionPerKm)
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
            return $"Truck travelled {kilometers} km";
        }
        else
        {
            return "Truck needs refueling";
        }
    }

    public void Refuel(double liters)
    {
        this.fuelQuantity += liters * 0.95;
    }

    public override string ToString()
    {
        return $"Truck: {this.fuelQuantity:f2}";
    }
}

