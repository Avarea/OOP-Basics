using System;

class Program
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateModifier date = new DateModifier();
        date.GetDayDifference(firstDate, secondDate);
    }
}

