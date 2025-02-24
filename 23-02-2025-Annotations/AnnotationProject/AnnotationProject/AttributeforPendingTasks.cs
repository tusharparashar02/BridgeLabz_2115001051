using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProject
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }
    public class Project
    {
        [Todo("Implement user login", "Tushar")]
        public void UserLogin() { }

        [Todo("Create API documentation", "Vikas", "HIGH")]
        public void ApiDocumentation() { }
    }

    class AttributeforPendingTasks
    {
        static void Main()
        {
            var methods = typeof(Project).GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(TodoAttribute), false).Any());

            foreach (var method in methods)
            {
                var attribute = (TodoAttribute)method.GetCustomAttributes(typeof(TodoAttribute), false).First();
                Console.WriteLine($"Task: {attribute.Task}, Assigned To: {attribute.AssignedTo}, Priority: {attribute.Priority}");
            }
        }
    }
}
