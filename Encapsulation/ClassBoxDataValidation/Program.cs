using System;

class Program
{
    static void Main()
    {
        try
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            Console.WriteLine(box.CalculateSurfaceArea(box));
            Console.WriteLine(box.CalculateLateralSurfaceArea(box));
            Console.WriteLine(box.CalculateVolume(box));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

