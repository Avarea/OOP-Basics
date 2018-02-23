using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var commandArguments = Console.ReadLine()?.Split();
            var person = new Person(commandArguments[0], commandArguments[1], int.Parse(commandArguments[2]), decimal.Parse(commandArguments[3]));
            persons.Add(person);
        }

        Team team = new Team("Bright");
        foreach (var p in persons)
        {
            team.AddPlayer(p);
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}
