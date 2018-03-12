using System;

class Program
{
    static void Main()
    {
        var studentInfo = Console.ReadLine()?.Split();
        string studentFirstName = studentInfo[0];
        string studentLastName = studentInfo[1];
        string facultyNumber = studentInfo[2];

        var workerInfo = Console.ReadLine()?.Split();
        string workerFirstName = workerInfo[0];
        string workerLastName = workerInfo[1];
        decimal weeklySalary = decimal.Parse(workerInfo[2]);
        decimal hoursPerDay = decimal.Parse(workerInfo[3]);
        try
        {
            Student student = new Student(studentFirstName, studentLastName, facultyNumber);
            Worker worker = new Worker(workerFirstName, workerLastName, weeklySalary, hoursPerDay);
            Console.WriteLine(student + Environment.NewLine);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

