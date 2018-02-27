using System;

public class Stat
{
    private const int statMinValue = 0;

    private const int statMaxValue = 100;

    private StatType statType;

    private StatType StatType
    {
        get { return statType; }
        set { statType = value; }
    }

    private int statValue;

    public int StatValue
    {
        get { return statValue; }
        private set
        {
            if (value < statMinValue || value > statMaxValue)
            {
                throw new ArgumentException($"{this.StatType} should be between {statMinValue} and {statMaxValue}.");
            }

            this.statValue = value;
        }
    }

    public Stat(StatType statType, int statValue)
    {
        this.StatType = statType;
        this.StatValue = statValue;
    }
}