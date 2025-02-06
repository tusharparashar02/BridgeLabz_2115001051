using System;
using System.Collections.Generic;

namespace Assignments{
    class Course{
        public string CourseName { get; set; }
        public List<Student> EnrolledStudents { get; } = new List<Student>();
        public Course(string courseName){
            CourseName = courseName;
        }
        // Enroll a student in the course
        public void EnrollStudent(Student student){
            if (!EnrolledStudents.Contains(student)){
                EnrolledStudents.Add(student);
                student.EnrollInCourse(this); // Establishing bidirectional relationship
            }
        }
        // Display all students enrolled in this course
        public void ShowEnrolledStudents(){
            Console.WriteLine("Students enrolled in " + CourseName + ":");
            foreach (var student in EnrolledStudents){
                Console.WriteLine("- " + student.Name);
            }
            Console.WriteLine("*");
        }
    }
    // Represents a student who can enroll in multiple courses
    class Student{
        public string Name { get; set; }
        public List<Course> EnrolledCourses { get; } = new List<Course>();
        public Student(string name){
            Name = name;
        }
        // Enroll the student in a course
        public void EnrollInCourse(Course course){
            if (!EnrolledCourses.Contains(course)){
                EnrolledCourses.Add(course);
                course.EnrollStudent(this); // Ensuring bidirectional relationship
            }
        }
        // Display all courses the student is enrolled in
        public void ShowEnrolledCourses(){
            Console.WriteLine(Name + " is enrolled in the following courses:");
            foreach (var course in EnrolledCourses){
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine("*");
        }
    }
    // Represents a school that contains students (aggregation relationship)
    class School{
        public string SchoolName { get; set; }
        public List<Student> Students { get; } = new List<Student>(); // Aggregation: School has students but does not own them
        public School(string schoolName){
            SchoolName = schoolName;
        }
        // Add a student to the school
        public void AddStudent(Student student){
            if (!Students.Contains(student)){
                Students.Add(student);
            }
        }
        // Display all students in the school
        public void ShowAllStudents(){
            Console.WriteLine("Students in " + SchoolName + ":");
            foreach (var student in Students){
                Console.WriteLine("- " + student.Name);
            }
            Console.WriteLine("*");
        }
    }
    class main{
        public static void Main(){
            // Create a school instance
            School mySchool = new School("High School");
            // Create student instances
            Student student1 = new Student("Student1");
            Student student2 = new Student("Student2");
            // Add students to the school
            mySchool.AddStudent(student1);
            mySchool.AddStudent(student2);
            // Create course instances
            Course math = new Course("Mathematics");
            Course science = new Course("Science");
            // Enroll students in courses
            student1.EnrollInCourse(math);
            student1.EnrollInCourse(science);
            student2.EnrollInCourse(math);
            // Display school students
            mySchool.ShowAllStudents();
            // Display enrolled courses for each student
            student1.ShowEnrolledCourses();
            student2.ShowEnrolledCourses();
            // Display enrolled students for each course
            math.ShowEnrolledStudents();
            science.ShowEnrolledStudents();
        }
    }
}