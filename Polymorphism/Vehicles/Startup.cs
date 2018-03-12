using System;

class Startup
{
    static void Main()
    {
        var carParameters = Console.ReadLine()?.Split();
        var truckParameters = Console.ReadLine()?.Split();
        Car car = new Car(double.Parse(carParameters[1]), double.Parse(carParameters[2]));
        Truck truck = new Truck(double.Parse(truckParameters[1]), double.Parse(truckParameters[2]));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
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
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}

