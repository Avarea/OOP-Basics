public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string email;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public Employee()
    {
        this.Age = -1;
        this.Email = "n/a";
    }

    public Employee(string name, decimal salary, string position, int age = -1, string email = "n/a")
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Age = age;
        this.Email = email;
    }
}