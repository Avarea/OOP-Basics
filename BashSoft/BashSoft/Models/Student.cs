using BashSoft;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string userName;
    public Dictionary<string, Course> EnrolledCourses;
    public Dictionary<string, double> MarksByCourseName;

    public Student(string userName)
    {
        this.userName = userName;
        this.EnrolledCourses = new Dictionary<string, Course>();
        this.MarksByCourseName = new Dictionary<string, double>();
    }

    public void EnrollInCourse(Course course)
    {
        if (this.EnrolledCourses.ContainsKey(course.name))
        {
            OutputWriter.DisplayException(string.Format(ExceptionMessages.StudentAlreadyEnrolledInGivenCourse, this.userName, course.name));
            return;
        }
        this.EnrolledCourses.Add(course.name, course);
    }

    public void SetMarksInCourse(string courseName, params int[] scores)
    {
        if (!this.EnrolledCourses.ContainsKey(courseName))
        {
            OutputWriter.DisplayException(ExceptionMessages.NotEnrolledInCourse);
            return;
        }
        if (scores.Length > Course.NumberOfTasksOnExam)
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
            return;
        }
        this.MarksByCourseName.Add(courseName, CalculateMark(scores));
    }

    private double CalculateMark(int[] scores)
    {
        double percentageOfSolvedExam =
            scores.Sum() / (double) (Course.NumberOfTasksOnExam * Course.MaxScoreOnExamTask);
        double mark = percentageOfSolvedExam * 4 + 2;
        return mark;
    }
}

