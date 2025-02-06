using System;
using System.Collections.Generic;

namespace Assignments
{
    // Employee class
    class Employee{
        public string Name { get; set; }
        public Employee(string name){
            Name = name;
        }
        public void ShowEmployee(){
            Console.WriteLine("Employee: " + Name);
        }
    }
    // Department class (Composition)
    class Department{
        public string DepartmentName { get; set; }
        private List<Employee> Employees = new List<Employee>();
        public Department(string departmentName){
            DepartmentName = departmentName;
        }
        public void AddEmployee(string employeeName){
            Employees.Add(new Employee(employeeName));
        }
        public void ShowEmployees(){
            Console.WriteLine("Department: " + DepartmentName);
            foreach (var employee in Employees){
                employee.ShowEmployee();
            }
            Console.WriteLine("");
        }
    }
    // Company class (Composition with Departments and Employees)
    class Company{
        public string CompanyName { get; set; }
        private List<Department> Departments = new List<Department>();
        public Company(string companyName){
            CompanyName = companyName;
        }
        public void AddDepartment(string departmentName){
            Departments.Add(new Department(departmentName));
        }
        public void AddEmployeeToDepartment(string departmentName, string employeeName){
            foreach (var dept in Departments){
                if (dept.DepartmentName == departmentName){
                    dept.AddEmployee(employeeName);
                    return;
                }
            }
            Console.WriteLine("Department not found: " + departmentName);
        }
        public void ShowCompanyStructure(){
            Console.WriteLine("Company: " + CompanyName);
            foreach (var dept in Departments){
                dept.ShowEmployees();
            }
            Console.WriteLine("");
        }
    }
    // Main Program
    class main{
        public static void Main(){
            // Create a Company
            Company company = new Company("Company1");
            // Add Departments
            company.AddDepartment("Engineering");
            company.AddDepartment("Human Resources");
            // Add Employees to Departments
            company.AddEmployeeToDepartment("Engineering", "Employee1");
            company.AddEmployeeToDepartment("Engineering", "Employee2");
            company.AddEmployeeToDepartment("Human Resources", "Employee3");
            // Show Company Structure
            company.ShowCompanyStructure();
        }
    }
}