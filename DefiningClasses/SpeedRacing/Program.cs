using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var cars = new Dictionary<string, Car>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()?.Split();
            string model = input[0];
            decimal fuelAmount = decimal.Parse(input[1]);
            decimal fuelConsumption = decimal.Parse(input[2]);

            if (!cars.ContainsKey(model))
            {
                cars.Add(model, new Car(model, fuelAmount,fuelConsumption));
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] parameters = command.Split();
            string model = parameters[1];
            decimal amountKm = decimal.Parse(parameters[2]);

            cars[model].Move(amountKm);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Value.ToString());
        }
    }
}
