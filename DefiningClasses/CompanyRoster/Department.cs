using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    private string name;

    public List<Employee> Employees
    {
        get { return employees; }
        set { this.employees = value; }
    }

    public string Name
    {
        get { return name; }
        set { this.name = value; }
    }

    public decimal AverageSalary => this.Employees.Select(e => e.Salary).Average();

    public Department(string name)
    {
        this.Name = name;
        this.Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }
}