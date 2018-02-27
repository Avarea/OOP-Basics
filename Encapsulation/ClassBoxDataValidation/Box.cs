using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get => length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public Box()
    {

    }
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    //Volume = lwh
    //    Lateral Surface Area = 2lh + 2wh
    //    Surface Area = 2lw + 2lh + 2wh
    public string CalculateSurfaceArea(Box box)
    {
        var area = (2 * length * width) + (2 * length * height) + (2 * width * height);
        return $"Surface Area - {area:f2}";
    }

    public string CalculateLateralSurfaceArea(Box box)
    {
        var area = (2 * length * height) + (2 * width * height);
        return $"Lateral Surface Area - {area:f2}";
    }

    public string CalculateVolume(Box box)
    {
        var area = length * height * width;
        return $"Volume - {area:f2}";
    }
}

