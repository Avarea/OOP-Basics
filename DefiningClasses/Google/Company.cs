using System;

public class Company
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Company()
    {
        this.Name = string.Empty;
        this.Department = string.Empty;
    }

    public Company(string name, string department, decimal salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    public override string ToString()
    {
        if (this.Name == string.Empty && this.Department == string.Empty)
        {
            return string.Empty;
        }
        else
        {
            return $"{Name} {Department} {Salary:f2}";
        }
    }
}

