using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student object created dynamically!");
        }
    }
    public class DynamicallyCreateObjects
    {
        static void Main()
        {
            Type type = typeof(Student);

            // Create instance dynamically without 'new'
            object obj = Activator.CreateInstance(type);
        }
    }
}
