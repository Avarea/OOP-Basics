using System.Collections.Generic;
using BashSoft;

public class Course
{
    public string name;
    public Dictionary<string, Student> StudentsByName;
    public const int NumberOfTasksOnExam = 5;
    public const int MaxScoreOnExamTask = 100;

    public Course(string name)
    {
        this.name = name;
        this.StudentsByName = new Dictionary<string, Student>();
    }

    public void EnrollStudent(Student student)
    {
        if (this.StudentsByName.ContainsKey(student.userName))
        {
            OutputWriter.DisplayException(string.Format(ExceptionMessages.StudentAlreadyEnrolledInGivenCourse,student.userName, this.name));
            return;
        }
        this.StudentsByName.Add(student.userName, student);
    }
}

