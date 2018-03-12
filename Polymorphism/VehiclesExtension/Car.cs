using System;

public class Car : IVehicle
{
    private double additionalConsumption = 0.9;
    public double fuelConsumptionPerKm { get; }
    public int tankCapacity { get; }

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


    public Car(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.tankCapacity = tankCapacity;
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
            this.fuelQuantity += liters;
        }
    }

    public override string ToString()
    {
        return $"Car: {this.fuelQuantity:f2}";
    }
}

