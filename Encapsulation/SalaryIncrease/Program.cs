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

        var percentage = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(percentage));
        persons.ForEach(Console.WriteLine);
    }
}

