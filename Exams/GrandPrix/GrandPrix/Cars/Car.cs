using System;

public class Car
{
    private const int TankCapacity = 160;
    private int hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if (value >= TankCapacity)
            {
                fuelAmount = TankCapacity;
            }

            if (value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            fuelAmount = value;
        }
    }

    public int Hp { get;}
    public Tyre Tyre { get; private set; }

    public void ReduceFuel(int length, double fuelConsumption)
    {
        this.FuelAmount = this.FuelAmount - (length * fuelConsumption);
    }

    public void Refuel(double fuel)
    {
        this.FuelAmount += fuel;
    }

    public void ChangeTyre(Tyre newTyre)
    {
        this.Tyre = newTyre;
    }
}

