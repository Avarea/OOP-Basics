using System.Collections.Generic;

public class CarFactory
{
    public static Car CreateCar(List<string> argument, Tyre tyre)
    {
        int hp = int.Parse(argument[0]);
        double fuelAmount = double.Parse(argument[1]);
        return new Car(hp,fuelAmount, tyre);
    }
}

