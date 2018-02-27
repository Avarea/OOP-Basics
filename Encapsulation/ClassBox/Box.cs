public class Box
{
    private double length;

    public double Length => length;

    private double width;

    public double Width => width;

    private double height;

    public double Height => height;

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
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

