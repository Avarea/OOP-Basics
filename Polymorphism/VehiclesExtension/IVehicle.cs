public interface IVehicle
{
    double FuelQuantity { get; set; }
    double fuelConsumptionPerKm { get; }
    int tankCapacity { get; }

    string Drive(double kilometers);
    void Refuel(double liters);
}

