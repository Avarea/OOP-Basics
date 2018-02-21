public class Person
{
    private int age;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} is {this.Age} years old";
    }
}
