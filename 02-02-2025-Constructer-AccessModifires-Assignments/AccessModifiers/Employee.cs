class Employee
{
    public int EmployeeID { get; set; }
    protected string Department { get; set; }
    private double Salary;

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void SetSalary(double salary)
    {
        Salary = salary;
    }
}

// Manager Class
class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int employeeID, string department, double salary, int teamSize)
        : base(employeeID, department, salary)
    {
        TeamSize = teamSize;
    }
}