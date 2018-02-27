using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int Rating
    {
        get { return this.CalculateTeamRaiting(); }
    }

    private List<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.players = new List<Player>();
    }

    public void AddPlayer(Player player)
    {
        this.players.Add(player);
    }

    private int CalculateTeamRaiting()
    {
        double sumPlayersStats = 0d;

        foreach (var player in this.players)
        {
            sumPlayersStats += player.CalculatePlayerStats();
        }

        return Convert.ToInt32(sumPlayersStats);
    }

    public void RemovePlayer(string playerName)
    {
        Player player = this.players.FirstOrDefault(x => x.Name.Equals(playerName));

        if (player == null)
        {
            throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
        }

        this.players.Remove(player);
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Rating}";
    }
}