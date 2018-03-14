using System;
using System.Linq;

class Program
{
    static void Main()
    {
        RaceTower raceTower = new RaceTower();
        var numberOfLaps = int.Parse(Console.ReadLine());
        var lengthOfTrack = int.Parse(Console.ReadLine());
        raceTower.SetTrackInfo(numberOfLaps, lengthOfTrack);

        string input = Console.ReadLine();
        while (true)
        {
            var commandArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = commandArgs.First();
            commandArgs.RemoveAt(0);

            switch (command)
            {
                case "RegisterDriver":
                    raceTower.RegisterDriver(commandArgs);
                    break;
                case "Leaderboard":
                    Console.WriteLine(raceTower.GetLeaderboard());
                    break;
                case "CompleteLaps":
                    var result = raceTower.CompleteLaps(commandArgs);
                    if (result != string.Empty)
                    {
                        Console.WriteLine(result);
                    }
                    break;
                case "Box":
                    raceTower.DriverBoxes(commandArgs);
                    break;
                case "ChangeWeather":
                    raceTower.ChangeWeather(commandArgs);
                    break;
            }

            if (raceTower.IsEndOfRace)
            {
                Console.WriteLine(
                    $"{raceTower.Winner.Name} wins the race for {raceTower.Winner.TotalTime:F3} seconds.");
                return;
            }
            input = Console.ReadLine();
        }
    }
}

