public interface IVehicle
{
    double fuelQuantity { get; }
    double fuelConsumptionPerKm { get; }
    string Drive(double kilometers);
    void Refuel(double liters);
}

