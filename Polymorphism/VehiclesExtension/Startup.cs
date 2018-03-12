using System;

class Startup
{
    static void Main()
    {
        var carParameters = Console.ReadLine()?.Split();
        var truckParameters = Console.ReadLine()?.Split();
        var busParameters = Console.ReadLine()?.Split();

        Car car = new Car(double.Parse(carParameters[1]), double.Parse(carParameters[2]), int.Parse(carParameters[3]));
        Truck truck = new Truck(double.Parse(truckParameters[1]), double.Parse(truckParameters[2]), int.Parse(truckParameters[3]));
        Bus bus = new Bus(double.Parse(busParameters[1]), double.Parse(busParameters[2]), int.Parse(busParameters[3]));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            CommandParser(car, truck, bus);
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void CommandParser(Car car, Truck truck, Bus bus)
    {
        var commandParams = Console.ReadLine()?.Split();
        string vechicle = commandParams[1];
        string command = commandParams[0];
        double number = double.Parse(commandParams[2]);
        if (vechicle == "Car")
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(car.Drive(number));
                    break;
                case "Refuel":
                    car.Refuel(number);
                    break;
            }
        }
        else if (vechicle == "Truck")
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(truck.Drive(number));
                    break;
                case "Refuel":
                    truck.Refuel(number);
                    break;
            }
        }
        else if (vechicle == "Bus")
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(bus.Drive(number));
                    break;
                case "DriveEmpty":
                    Console.WriteLine(bus.DriveEmpty(number));
                    break;
                case "Refuel":
                    bus.Refuel(number);
                    break;
            }
        }
    }
}

