using System;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workingHoursPerDay;

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public decimal WorkingHoursPerDay
    {
        get { return workingHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHoursPerDay = value;
        }
    }

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHoursPerDay = workingHoursPerDay;
    }


    public decimal CalculateMoneyPerHour()
    {
        return weekSalary / (WorkingHoursPerDay * 5);
    }

    public override string ToString()
    {
        return $"First Name: {base.FirstName}" + Environment.NewLine +
               $"Last Name: {base.LastName}" + Environment.NewLine +
               $"Week Salary: {this.WeekSalary:f2}" + Environment.NewLine +
               $"Hours per day: {this.WorkingHoursPerDay:f2}" + Environment.NewLine +
               $"Salary per hour: {CalculateMoneyPerHour():f2}" + Environment.NewLine;
    }
}


