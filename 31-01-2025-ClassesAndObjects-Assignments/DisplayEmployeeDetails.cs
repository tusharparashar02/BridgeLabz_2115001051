using System;

class DisplayEmployeeDetails{
    public string Name;
    public int Id;
    public double Salary;

    public void DisplayDetails(){
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }

    static void Main(string[] args){
        DisplayEmployeeDetails emp = new DisplayEmployeeDetails();
        emp.Name = "Tushar Parashar";
        emp.Id = 193;
        emp.Salary = 30000;

        emp.DisplayDetails();
    }
}
