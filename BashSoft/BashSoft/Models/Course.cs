﻿using System.Collections.Generic;
using BashSoft.Exceptions;

public class Course
{
    private string name;
    private Dictionary<string, Student> studentsByName;
    public const int NumberOfTasksOnExam = 5;
    public const int MaxScoreOnExamTask = 100;

    public Course(string name)
    {
        this.Name = name;
        this.studentsByName = new Dictionary<string, Student>();
    }

    public string Name
    {
        get
        {
            return this.name;

        }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidStringException();
            }

            this.name = value;
        }
    }

    public Dictionary<string, Student> StudentsByName
    {
        get { return this.studentsByName; }
    }

    public void EnrollStudent(Student student)
    {
        if (this.StudentsByName.ContainsKey(student.UserName))
        {
            throw new DuplicateEntryInStructureException(student.UserName, this.Name);

        }
        this.StudentsByName.Add(student.UserName, student);
    }
}

