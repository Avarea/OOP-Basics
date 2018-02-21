using System;

public class DateModifier
{
    private int daysDiff;

    public int DaysDiff
    {
        get { return daysDiff; }
        set { daysDiff = value; }
    }

    public override string ToString()
    {
        return $"{this.DaysDiff}";
    }

    public void GetDayDifference(string date1, string date2)
    {
        DateTime firstDate = Convert.ToDateTime(date1);
        DateTime secondDate = Convert.ToDateTime(date2);
        var difference = firstDate.Subtract(secondDate);
        Console.WriteLine(Math.Abs(difference.Days));
    }
}
