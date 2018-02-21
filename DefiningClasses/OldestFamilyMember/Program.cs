using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();
        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine().Split();
            Person person = new Person(int.Parse(input[1]), input[0]);
            family.AddMember(person);
            if (i == n)
            {
                Console.WriteLine(family.GetOldestMember());
            }
        }
    }
}

