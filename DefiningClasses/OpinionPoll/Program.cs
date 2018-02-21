using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Person> list = new List<Person>();
        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine().Split();
            Person person = new Person(int.Parse(input[1]), input[0]);
            list.Add(person);
        }
        Console.WriteLine(string.Join(Environment.NewLine,list.OrderBy(a => a.Name).Where(a => a.Age > 30)));
    }
}

