using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        NationsBuilder nationsBuilder = new NationsBuilder();

        string input = Console.ReadLine();
        while (true)
        {
            var commandArgs = input.Split();
            var commandType = commandArgs[0];
            var mathodArgs = commandArgs.Skip(1).ToList();

            switch (commandType)
            {
                case "Bender":
                    nationsBuilder.AssignBender(mathodArgs);
                    break;
                case "Monument":
                    nationsBuilder.AssignMonument(mathodArgs);
                    break;
                case "Status":
                    string status = nationsBuilder.GetStatus(mathodArgs[0]);
                    Console.WriteLine(status);
                    break;
                case "War":
                    nationsBuilder.IssueWar(mathodArgs[0]);
                    break;
                case "Quit":
                    string record = nationsBuilder.GetWarsRecord();
                    Console.WriteLine(record);
                    Environment.Exit(0);
                    break;
            }
            input = Console.ReadLine();
        }
    }
}

