using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class StudentRecord
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public string Grade;
        public StudentRecord next;

        public StudentRecord(int roll, string name, int age, string grade) {
            RollNumber = roll;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
    class StudentSingleList
    {
        private StudentRecord head;
        //Add a new student record at the beginning
        public void AddStudentAtBeginning(int roll, string name, int age, string grade)
        {
            StudentRecord newNode = new StudentRecord(roll, name, age, grade);
            if (head == null)
            {
                head = newNode;
            }
            newNode.next = head;
            head = newNode;
        }
        //Add a new student record at the end
        public void AddStudentAtLast(int roll, string name, int age, string grade)
        {
            StudentRecord newNode = new StudentRecord(roll, name, age, grade);
            if (head == null)
            {
                head = newNode;
            }
            StudentRecord temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
        
        //method to add student at the given position in the list
        public StudentRecord AddStudentAtGivenPosition(int rollNo, string name, int age, string grade, int position)
        {
            StudentRecord newStudent = new StudentRecord(rollNo, name, age, grade);
            StudentRecord temp = head;
            StudentRecord tmp = head;

            int len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }
            if (position > len + 1 || position < 0)
                Console.WriteLine("Enter valid position");
            else
            {
                if (position == 1)
                    AddStudentAtBeginning(rollNo, name, age, grade);
                position--;
                while (position > 1)
                {
                    tmp = tmp.next;
                    position--;
                }
                newStudent.next = tmp.next;
                tmp.next = newStudent;
            }
            return head;
        }

        //method to search student in the list
        public StudentRecord SearchStudent(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            StudentRecord temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                if (temp.RollNumber == rollNo)
                {
                    Console.WriteLine("sutudent found at " + count + " position");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to delete student from the list
        public StudentRecord DeleteStudent(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            StudentRecord temp = head;
            int count = 0;
            while (temp.next != null)
            {
                count++;
                if (temp.next.RollNumber == rollNo)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("sutudent deleted ");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to update student grade in the list
        public StudentRecord UpdateStudent(int rollNo, string grade)
        {
            if (head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            StudentRecord temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                if (temp.RollNumber == rollNo)
                {
                    temp.Grade = grade;
                    Console.WriteLine("sutudent grade has been updated ");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to display student list
        void Display()
        {
            StudentRecord temp = head;
            while (temp != null)
            {
                Console.Write("[" + temp.Name + "]->");
                temp = temp.next;
            }
            Console.WriteLine("[null]");
            Console.WriteLine("");
        }

        //main method to test the class
        public static void Main1()
        {


            StudentSingleList obj = new StudentSingleList();

            obj.AddStudentAtBeginning(02, "Student2", 19, "A");
            obj.Display();
            obj.AddStudentAtBeginning(01, "Student1", 19, "A+");
            obj.Display();
            obj.AddStudentAtLast(04, "Stuent4", 19, "A");
            obj.Display();
            obj.AddStudentAtLast(06, "Stuent6", 19, "B");
            obj.Display();
            obj.AddStudentAtGivenPosition(03, "Student3", 18, "A", 2);
            obj.Display();
            obj.AddStudentAtGivenPosition(05, "Student5", 18, "C", 5);
            obj.Display();
            obj.SearchStudent(06);
            obj.DeleteStudent(03);
            obj.Display();
            obj.UpdateStudent(02, "A+");

        }
    }
}
