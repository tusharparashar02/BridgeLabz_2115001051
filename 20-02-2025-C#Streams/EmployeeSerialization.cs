using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string filePath = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Tushar", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Parashar", Department = "HR", Salary = 50000 }
        };

        try
        {
            // Serialize and Save to File
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employees data saved.");

            // Deserialize and Read from File
            string readData = File.ReadAllText(filePath);
            List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(readData);
            Console.WriteLine("Employee List:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine($"{emp.Id}: {emp.Name} - {emp.Department} - {emp.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
