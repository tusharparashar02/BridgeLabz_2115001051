using System;
using System.Collections.Generic;

// 1. Abstract base class for course types
public abstract class CourseType
{
    public string CourseName { get; set; }
    public string Department { get; set; }

    public CourseType(string courseName, string department)
    {
        CourseName = courseName;
        Department = department;
    }

    // Abstract method for evaluation criteria
    public abstract void Evaluate();
}

// 2. Derived class: Exam-based courses
public class ExamCourse : CourseType
{
    public int ExamMarks { get; set; }

    public ExamCourse(string courseName, string department, int examMarks)
        : base(courseName, department)
    {
        ExamMarks = examMarks;
    }

    public override void Evaluate()
    {
        Console.WriteLine("[Exam Course] " + CourseName + " Department: " + Department + "Exam Marks: " + ExamMarks);
    }
}

// 3. Derived class: Assignment-based courses
public class AssignmentCourse : CourseType
{
    public int AssignmentCount { get; set; }

    public AssignmentCourse(string courseName, string department, int assignmentCount)
        : base(courseName, department)
    {
        AssignmentCount = assignmentCount;
    }

    public override void Evaluate()
    {
        Console.WriteLine("[Assignment Course] " + CourseName + "Department: " + Department + "Total Assignments: " + AssignmentCount);
    }
}

// 4. Generic course manager
public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
        Console.WriteLine(course.CourseName + " added to " + course.Department + " department.");
    }

    public void DisplayCourses()
    {
        Console.WriteLine("Available Courses:");
        foreach (var course in courses)
        {
            course.Evaluate();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Course<ExamCourse> examCourseManager = new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourseManager = new Course<AssignmentCourse>();

        examCourseManager.AddCourse(new ExamCourse("Data Structures", "Computer Science", 100));
        examCourseManager.AddCourse(new ExamCourse("Mathematics", "Mathematics", 80));

        assignmentCourseManager.AddCourse(new AssignmentCourse("Software Engineering", "Computer Science", 5));
        assignmentCourseManager.AddCourse(new AssignmentCourse("Project Management", "Humanities", 3));

        examCourseManager.DisplayCourses();
        assignmentCourseManager.DisplayCourses();
    }
}
