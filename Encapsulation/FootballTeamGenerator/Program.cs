using System;
using System.Linq;

class Program
{
    static void Main()
    {
        League league = new League();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                string[] tokens = ReadData(input);

                string command = tokens[0];

                string teamName = tokens[1];

                switch (command)
                {
                    case "Team":
                        league.AddTeam(teamName);
                        break;
                    case "Add":
                        string playerName = tokens[2];
                        int[] stats = tokens.Skip(3).Select(int.Parse).ToArray();
                        league.AddPlayerToTeam(teamName, playerName, stats);
                        break;
                    case "Remove":
                        playerName = tokens[2];
                        league.RemovePlayer(teamName, playerName);
                        break;
                    case "Rating":
                        league.RatingTeam(teamName);
                        break;
                    default: throw new InvalidOperationException("Invalid command.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private static string[] ReadData(string input)
    {
        return input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
    }
}

