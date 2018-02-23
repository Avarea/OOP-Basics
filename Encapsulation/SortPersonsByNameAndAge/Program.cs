using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var commandArguments = Console.ReadLine()?.Split();
            var person = new Person(commandArguments[0], commandArguments[1], int.Parse(commandArguments[2]));
            persons.Add(person);
        }

        persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}

