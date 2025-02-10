using System;
using System.Collections.Generic;

abstract class Employee
{
    protected int empId;

    protected string name;

    protected double baseSalary;

    public int EmpId { get { return empId; } set { empId = value; } }

    public string Name { get { return name; } set { name = value; } }

    public double BaseSal { get { return baseSalary; } set { baseSalary = value; } }

    public Employee(int id, string n, double s)
    {
        empId = id;

        name = n;

        baseSalary = s;
    }

    public abstract double CalculateSalary();

    public void Display()
    {
        Console.WriteLine("ID: " + empId + ", Name: " + name + ", Salary: " + CalculateSalary());
    }
}

interface IDepartment
{
    void AssignDept(string dept);
    string GetDept();
}

class FullTimeEmp : Employee, IDepartment
{
    private string dept;

    public FullTimeEmp(int id, string n, double s) : base(id, n, s) { }

    public override double CalculateSalary()
    {
        return baseSalary;
    }

    public void AssignDept(string d)
    {
        dept = d;
    }

    public string GetDept()
    {
        return dept;
    }
}

class PartTimeEmp : Employee, IDepartment
{
    private string dept;

    private int hours;

    private double rate;

    public PartTimeEmp(int id, string n, double r, int h) : base(id, n, 0)
    {
        rate = r;
        hours = h;
    }

    public override double CalculateSalary()
    {
        return rate * hours;
    }

    public void AssignDept(string d)
    {
        dept = d;
    }

    public string GetDept()
    {
        return dept;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> emps = new List<Employee>();

        emps.Add(new FullTimeEmp(1, "tushar", 1000));

        emps.Add(new PartTimeEmp(2, "Parashar", 30, 2000));

        foreach (Employee emp in emps)
        {
            emp.Display();
        }
    }
}