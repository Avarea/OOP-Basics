using System;

public class Bus : IVehicle
{
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



    public double fuelConsumptionPerKm { get; }
    public int tankCapacity { get; }
    private double additionalConsumption = 1.4;

    public Bus(double fuelQuantity, double fuelConsumptionPerKm, int tankCapacity)
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
            return $"Bus travelled {kilometers} km";
        }
        else
        {
            return "Bus needs refueling";
        }
    }

    public string DriveEmpty(double kilometers)
    {
        double fuelNeeded = this.fuelConsumptionPerKm * kilometers;
        if (fuelNeeded < this.fuelQuantity)
        {
            this.fuelQuantity -= fuelNeeded;
            return $"Bus travelled {kilometers} km";
        }
        else
        {
            return "Bus needs refueling";
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
        return $"Bus: {this.fuelQuantity:f2}";
    }
}

