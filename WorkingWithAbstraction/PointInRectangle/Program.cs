using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var coodrs = Console.ReadLine().Split().Select(int.Parse).ToList();
        Rectangle rectangle = new Rectangle(coodrs[0], coodrs[1], coodrs[2], coodrs[3]);

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var cmdPoint = Console.ReadLine().Split().Select(int.Parse).ToList();
            int pointX = cmdPoint[0];
            int pointY = cmdPoint[1];
            Point point = new Point(pointX, pointY);

            Console.WriteLine(rectangle.Contains(point));
        }
    }
}

