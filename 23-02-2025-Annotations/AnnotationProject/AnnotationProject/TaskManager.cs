using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProject
{
    // Define the custom attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class TaskInfoAttribute : Attribute
    {
        public int Priority { get; }
        public string AssignedTo { get; }

        public TaskInfoAttribute(int priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    public class TaskManager
    {
        [TaskInfo(1, "Tushar Parashar")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed!");
        }
    }
    class Manager
    {
        static void Main()
        {
            MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
            var attributes = (TaskInfoAttribute[])method.GetCustomAttributes(typeof(TaskInfoAttribute), false);

            foreach (var attr in attributes)
            {
                Console.WriteLine($"Task Priority: {attr.Priority}, Assigned To: {attr.AssignedTo}");
            }
        }
    }
}
