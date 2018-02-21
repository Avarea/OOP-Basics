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

    public Person()
    {
        this.Age = 1;
        this.Name = "No name";
    }

    public Person(int age)
    {
        this.Age = age;
        this.Name = "No name";
    }

    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }
}
