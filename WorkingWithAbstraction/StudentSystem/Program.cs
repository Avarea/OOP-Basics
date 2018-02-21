using System;

class Program
{
    static void Main()
    {
        StudentSystem studentSystem = new StudentSystem();
        string[] args = Console.ReadLine()?.Split();

        while (args[0] != "Exit")
        {
            studentSystem.ParseCommand(args);
            args = Console.ReadLine()?.Split();
        }
    }
}

