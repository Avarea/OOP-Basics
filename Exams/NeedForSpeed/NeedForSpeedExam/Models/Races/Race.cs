using System.Collections.Generic;

public abstract class Race
{
    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
    }

    public int Length { get; set; }
    public string Route { get; set; }
    public int PrizePool { get; set; }
    public Dictionary<int,Car> Participants { get; private set; }

    public abstract int GetPerformancePoints();

}

