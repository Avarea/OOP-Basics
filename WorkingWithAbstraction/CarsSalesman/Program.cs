using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    static void Main()
    {
        List<Engine> engines = new List<Engine>();
        int engineCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < engineCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ParseEngine(engines, parameters);
        }

        List<Car> cars = new List<Car>();
        int carCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine()?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ParseCar(cars, engines, parameters);
        }

        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static void ParseCar(List<Car> cars, List<Engine> engines, string[] parameters)
    {
        string model = parameters[0];
        string engineModel = parameters[1];
        Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

        if (parameters.Length == 3 && int.TryParse(parameters[2], out var weight))
        {
            cars.Add(new Car(model, engine, weight));
        }
        else if (parameters.Length == 3)
        {
            string color = parameters[2];
            cars.Add(new Car(model, engine, color));
        }
        else if (parameters.Length == 4)
        {
            string color = parameters[3];
            cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
        }
        else
        {
            cars.Add(new Car(model, engine));
        }
    }

    private static void ParseEngine(List<Engine> engines, string[] parameters)
    {
        string model = parameters[0];
        int power = int.Parse(parameters[1]);

        if (parameters.Length == 3 && int.TryParse(parameters[2], out var displacement))
        {
            engines.Add(new Engine(model, power, displacement));
        }
        else if (parameters.Length == 3)
        {
            string efficiency = parameters[2];
            engines.Add(new Engine(model, power, efficiency));
        }
        else if (parameters.Length == 4)
        {
            string efficiency = parameters[3];
            engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
        }
        else
        {
            engines.Add(new Engine(model, power));
        }
    }
}


