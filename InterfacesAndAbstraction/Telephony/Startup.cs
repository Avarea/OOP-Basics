using System;


class Startup
{
    static void Main()
    {
        var phoneInput = Console.ReadLine()?.Split();
        var websiteInput = Console.ReadLine()?.Split();

        Smartphone smartphone = new Smartphone();
        foreach (var number in phoneInput)
        {
            Console.WriteLine(smartphone.Calling(number));
        }
        foreach (var site in websiteInput)
        {
            Console.WriteLine(smartphone.Browsing(site));
        }
    }
}

