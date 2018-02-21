public class Parent
{
    public string Name { get; set; }
    public string Birthday { get; set; }

    public Parent()
    {
        
    }

    public Parent(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}
