public class Rectangle : Shape
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA
    {
        get { return sideA; }
        set { sideA = value; }
    }

    public double SideB
    {
        get { return sideB; }
        set { sideB = value; }
    }

    public override double CalculatePerimeter()
    {
        double result = this.SideA * 2 + this.SideB * 2;
        return result;
    }

    public override double CalculateArea()
    {
        double result = this.SideA * this.SideB;
        return result;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

