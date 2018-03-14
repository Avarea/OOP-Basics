using System;

public abstract class Tyre
{
    private string name;
    private double hardness;
    private double degradation;

    protected Tyre(double hardness)
    {
        this.Hardness = hardness;
        this.Degradation = 100;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Hardness
    {
        get { return hardness; }
        set { hardness = value; }
    }

    public virtual double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}
