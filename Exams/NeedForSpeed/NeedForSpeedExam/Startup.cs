using System;
using System.Linq;

class Startup
{

    static void Main()
    {
        CarManager manager = new CarManager();

        string inputCommand;

        while ((inputCommand = Console.ReadLine()) != "Cops Are Here")
        {
            var splitCommand = inputCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = splitCommand[0];

            switch (command)
            {
                case "register":
                    var id = int.Parse(splitCommand[1]);
                    var type = splitCommand[2];
                    var brand = splitCommand[3];
                    var model = splitCommand[4];
                    var year = int.Parse(splitCommand[5]);
                    var horsepower = int.Parse(splitCommand[6]);
                    var acceleration = int.Parse(splitCommand[7]);
                    var suspension = int.Parse(splitCommand[8]);
                    var durability = int.Parse(splitCommand[9]);
                    manager.Register(id,type,brand, model, year, horsepower, acceleration, suspension, durability);
                    break;

                case "check":
                    var checkId = int.Parse(splitCommand[1]);
                    Console.WriteLine(manager.Check(checkId));
                    break;

                case "open":
                    var raceId = int.Parse(splitCommand[1]);
                    var raceType = splitCommand[2];
                    var length = int.Parse(splitCommand[3]);
                    var route = splitCommand[4];
                    var prizePool = int.Parse(splitCommand[5]);
                    manager.Open(raceId, raceType, length, route, prizePool);
                    break;

                case "participate":
                    var carId = int.Parse(splitCommand[1]);
                    var idRace = int.Parse(splitCommand[2]);
                    manager.Participate(carId, idRace);
                    break;

                case "start":
                    var raceIdStart = int.Parse(splitCommand[1]);
                    Console.WriteLine(manager.Start(raceIdStart));
                    break;

                case "park":
                    var parkedCarId = int.Parse(splitCommand[1]);
                    manager.Park(parkedCarId);
                    break;

                case "unpark":
                    var unparkCarId = int.Parse(splitCommand[1]);
                    manager.Unpark(unparkCarId);
                    break;

                case "tune":
                    var tuneIndex = int.Parse(splitCommand[1]);
                    var tuneAddon = splitCommand[2];
                    manager.Tune(tuneIndex, tuneAddon);
                    break;
            }
        }
    }
}


