using System;
using System.Collections.Generic;

namespace Assignments{
    class Faculty{
        public string Name { get; set; }
        public Faculty(string name){
            Name = name;
        }
    }
    class Department1{
        public string DepartmentName { get; set; }
        public Department1(string departmentName){
            DepartmentName = departmentName;
        }
    }
    class University{
        public string UniversityName { get; set; }
        private List<Department1> Departments { get; } = new List<Department1>(); 
        public List<Faculty> FacultyMembers { get; } = new List<Faculty>(); 
        public University(string universityName){
            UniversityName = universityName;
        }
        public void AddDepartment(string departmentName){
            Departments.Add(new Department1(departmentName));
        }
        public void AddFaculty(Faculty faculty){
            if (!FacultyMembers.Contains(faculty)){
                FacultyMembers.Add(faculty);
            }
        }
        public void ShowDepartments(){
            Console.WriteLine("Departments in " + UniversityName + ":");
            foreach (var department in Departments){
                Console.WriteLine("- " + department.DepartmentName);
            }
            Console.WriteLine("*");
        }
        public void ShowFaculty(){
            Console.WriteLine("Faculty members in " + UniversityName + ":");
            foreach (var faculty in FacultyMembers){
                Console.WriteLine("- " + faculty.Name);
            }
            Console.WriteLine("*");
        }
    }
    // Main program
    class Class5
    {
        public static void Main5()
        {
            // Create a university instance
            University myUniversity = new University("GLA University");

            // Create faculty members
            Faculty faculty1 = new Faculty("Faculty1");
            Faculty faculty2 = new Faculty("Faculty2");

            // Add faculty members to the university
            myUniversity.AddFaculty(faculty1);
            myUniversity.AddFaculty(faculty2);

            // Add departments to the university
            myUniversity.AddDepartment("Computer Science");
            myUniversity.AddDepartment("Mechanical Engineering");

            // Display university faculty and departments
            myUniversity.ShowFaculty();
            myUniversity.ShowDepartments();
        }
    }

}