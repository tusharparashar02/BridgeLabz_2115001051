using System;

namespace Assignments
{
    // Base class
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
        }
    }

    // Subclass: Manager
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}, Team Size: {TeamSize}");
        }
    }

    // Subclass: Developer
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}, Programming Language: {ProgrammingLanguage}");
        }
    }

    // Subclass: Intern
    class Intern : Employee
    {
        public string InternshipDuration { get; set; }

        public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}, Internship Duration: {InternshipDuration}");
        }
    }

    class Class2
    {
        public static void Main2()
        {
            Employee manager = new Manager("Manager", 101, 89000, 10);
            Employee developer = new Developer("Developer", 102, 10000, "C#");
            Employee intern = new Intern("Intern", 103, 78000, "4 months");

            manager.DisplayDetails();
            developer.DisplayDetails();
            intern.DisplayDetails();
        }
    }
}
