using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string[] carParameters = Console.ReadLine()?.Split();
            string model = carParameters[0];
            int engineSpeed = int.Parse(carParameters[1]);
            int enginePower = int.Parse(carParameters[2]);
            Engine engine = new Engine(engineSpeed,enginePower);

            int cargoWeight = int.Parse(carParameters[3]);
            string cargoType = carParameters[4];
            Cargo cargo = new Cargo(cargoWeight,cargoType);

            List<Tire> tires = new List<Tire>();

            for (int j = 0; j < 8; j+=2)
            {
                double tirePressure = double.Parse(carParameters[j + 5]);
                int tireAge = int.Parse(carParameters[j + 6]);
                Tire tire = new Tire(tirePressure, tireAge);
                tires.Add(tire);
            }
            cars.Add(new Car(model, engine, cargo, tires));
        }

        string command = Console.ReadLine();
        switch (command)
        {
            case "fragile":
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command && c.Tires.Any(t => t.TirePressure < 1.0)))
                {
                    Console.WriteLine($"{car.Model}");
                }
                break;
            case "flamable":
                foreach (var car in cars.Where(c => c.Cargo.CargoType == command && c.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
                break;
        }
    }
}

