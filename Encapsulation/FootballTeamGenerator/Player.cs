using System;
using System.Collections.Generic;

public class Player
{
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            name = value;
        }
    }

    private List<Stat> stats;

    public Player(string name, int[] stats)
    {
        if (stats.Length != 5)
        {
            throw new ArgumentException("Invalid data input.");
        }

        this.Name = name;
        this.stats = new List<Stat>
        {
            new Stat(StatType.Endurance, stats[0]),
            new Stat(StatType.Sprint, stats[1]),
            new Stat(StatType.Dribble, stats[2]),
            new Stat(StatType.Passing, stats[3]),
            new Stat(StatType.Shooting, stats[4])
        };
    }

    public double CalculatePlayerStats()
    {
        double sumStats = 0d;

        foreach (var stat in this.stats)
        {
            sumStats += stat.StatValue;
        }

        return sumStats / this.stats.Count;
    }
}