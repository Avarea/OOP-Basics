using System;

public class Truck : IVehicle
{
    private double additionalConsumption = 1.6;
    public double fuelConsumptionPerKm { get; }
    public int tankCapacity { get; }

    public Truck(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.tankCapacity = tankCapacity;
    }

    private double fuelQuantity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            if (value > tankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
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
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (this.fuelQuantity + liters >= this.tankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
        else
        {
            this.fuelQuantity += liters * 0.95;
        }
    }

    public override string ToString()
    {
        return $"Truck: {this.fuelQuantity:f2}";
    }
}

