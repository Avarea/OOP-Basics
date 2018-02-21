using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Department> departments = new List<Department>();

        for (int i = 0; i < n; i++)
        {
            string[] employeeInput = Console.ReadLine()?.Split();
            string departmentName = employeeInput[3];

            if (departments.All(d => d.Name != departmentName))
            {
                Department dept = new Department(departmentName);
                departments.Add(dept);
            }
            var department = departments.FirstOrDefault(d => d.Name == departmentName);
            Employee employee = ParseEmployee(employeeInput);
            department.AddEmployee(employee);
        }

        var higestAvgDept = departments.OrderByDescending(d => d.AverageSalary).First();
        Console.WriteLine($"Highest Average Salary: {higestAvgDept.Name}");
        foreach (var em in higestAvgDept.Employees.OrderByDescending(s => s.Salary))
        {
            Console.WriteLine($"{em.Name} {em.Salary:f2} {em.Email} {em.Age}");
        }
    }

    static Employee ParseEmployee(string[] employeeInput)
    {
        string name = employeeInput[0];
        decimal salary = decimal.Parse(employeeInput[1]);
        string position = employeeInput[2];

        string email = "n/a";
        int age = -1;

        if (employeeInput.Length == 6)
        {
            email = employeeInput[4];
            age = int.Parse(employeeInput[5]);
        }
        else if (employeeInput.Length == 5)
        {
            bool isAge = int.TryParse(employeeInput[4], out age);
            if (!isAge)
            {
                email = employeeInput[4];
                age = -1;
            }
        }
        Employee employee = new Employee(name, salary, position, age, email);
        return employee;
    }
}

