public class Ferarri : ICar
{
    public string Model { get; private set; }
    public string DriverName { get; private set; }
    public Ferarri(string driverName)
    {
        this.Model = "488-Spider";
        this.DriverName = driverName;
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{Brakes()}/{Gas()}/{this.DriverName}";
    }
}

