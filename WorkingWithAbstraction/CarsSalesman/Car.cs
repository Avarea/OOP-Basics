using System.Text;

public class Car
{


    public string Model;
    public Engine Engine;
    public int Weight;
    public string Color;

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = -1;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = -1;
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

    public override string ToString()
    {
        string offset = "  ";
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}:\n", this.Model);
        sb.Append(this.Engine);
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.Weight == -1 ? "n/a" : this.Weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, this.Color);
        return sb.ToString();
    }
}