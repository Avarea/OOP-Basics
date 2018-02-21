using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] rectangleParams = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
        int numOfRectangles = rectangleParams[0];
        int numOfIntersections = rectangleParams[1];

        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();
        for (int i = 0; i < numOfRectangles; i++)
        {
            string[] inputParams = Console.ReadLine()?.Split();
            string id = inputParams[0];
            double width = double.Parse(inputParams[1]);
            double height = double.Parse(inputParams[2]);
            double topLeftX = double.Parse(inputParams[3]);
            double topLeftY = double.Parse(inputParams[4]);

            rectangles.Add(id, new Rectangle(id, width,height,new Point(topLeftX, topLeftY)));
        }

        for (int i = 0; i < numOfIntersections; i++)
        {
            string[] pair = Console.ReadLine()?.Split();
            string firstId = pair[0];
            string secondId = pair[1];

            if (rectangles.ContainsKey(firstId))
            {
                Rectangle first = rectangles[firstId];
                if (rectangles.ContainsKey(secondId))
                {
                    Rectangle second = rectangles[secondId];
                    Console.WriteLine(first.IsIntersectWith(second).ToString().ToLower());
                }
            }
        }
    }
}
