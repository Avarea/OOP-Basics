public class Children
{
    public string Name { get; set; }
    public string Birthday { get; set; }

    public Children()
    {
        
    }

    public Children(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}

