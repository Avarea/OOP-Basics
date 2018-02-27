using System;
using System.Collections.Generic;
using System.Linq;

public class League
{
    private Dictionary<string, Team> Teams { get; set; } = new Dictionary<string, Team>();

    public void AddTeam(string teamName)
    {
        if (this.Teams.ContainsKey(teamName))
        {
            throw new ArgumentException($"Team {teamName} already exists.");
        }

        Teams[teamName] = new Team(teamName);
    }

    public void AddPlayerToTeam(string teamName, string playerName, int[] stats)
    {
        Team team = this.Teams.FirstOrDefault(x => x.Key == teamName).Value;

        if (team == null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }

        team.AddPlayer(new Player(playerName, stats));
    }

    public void RemovePlayer(string teamName, string playerName)
    {
        Team team = this.Teams.FirstOrDefault(x => x.Key == teamName).Value;

        if (team == null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }

        team.RemovePlayer(playerName);
    }

    public void RatingTeam(string teamName)
    {
        Team team = this.Teams.FirstOrDefault(x => x.Key == teamName).Value;

        if (team == null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }

        Console.WriteLine(team);
    }
}