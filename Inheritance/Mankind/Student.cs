using System;

public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            if (!ValidateFacultyNumber(value))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        return $"First Name: {base.FirstName}" + Environment.NewLine +
               $"Last Name: {base.LastName}" + Environment.NewLine +
               $"Faculty number: {this.FacultyNumber}";
    }


    private bool ValidateFacultyNumber(string value)
    {
        if (value.Length < 5 || value.Length > 10)
        {
            return false;
        }

        foreach (var c in value)
        {
            if (!char.IsLetterOrDigit(c)) return false;
        }

        return true;
    }
}

