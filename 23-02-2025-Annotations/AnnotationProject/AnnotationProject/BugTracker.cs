using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProject
{
    // Define the custom attribute with AllowMultiple = true
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class BugReportAttribute : Attribute
    {
        public string Description { get; }

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }
    public class BugTracker
    {
        [BugReport("Null reference exception when input is null")]
        [BugReport("Performance issue when processing large data")]
        public void ProcessData()
        {
            Console.WriteLine("Processing data");
        }
    }
    class Bug
    {
        static void Main()
        {
            MethodInfo method = typeof(BugTracker).GetMethod("ProcessData");
            var attributes = (BugReportAttribute[])method.GetCustomAttributes(typeof(BugReportAttribute), false);

            Console.WriteLine("Bug Reports:");
            foreach (var attr in attributes)
            {
                Console.WriteLine($" {attr.Description}");
            }
        }
    }
}
