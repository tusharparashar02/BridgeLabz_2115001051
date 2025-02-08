using System;


namespace Assignments
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("This is a person in the school system.");
        }
    }

    // Subclass: Teacher
    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Teacher - Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }

    // Subclass: Student
    class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Student - Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }

    // Subclass: Staff
    class Staff : Person
    {
        public string Department { get; set; }

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Staff - Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }

    class Class9
    {
        public static void Main9()
        {
            Person teacher = new Teacher("Teacher", 50, "Physics");
            Person student = new Student("Student", 17, 09);
            Person staff = new Staff("Staff", 25, "Administration");

            teacher.DisplayRole();
            student.DisplayRole();
            staff.DisplayRole();
        }
    }
}
