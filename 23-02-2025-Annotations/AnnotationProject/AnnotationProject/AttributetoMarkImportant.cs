using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProject
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantMethodAttribute : Attribute
    {
        public string Level { get; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
    public class Example
    {
        [ImportantMethod("HIGH")]
        public void CriticalMethod()
        {
            Console.WriteLine("This is a critical method.");
        }

        [ImportantMethod("LOW")]
        public void LessImportantMethod()
        {
            Console.WriteLine("This is a less important method.");
        }
    }
    public class AttributetoMarkImportant
    {
        static void Main()
        {
            var methods = typeof(Example).GetMethods()
                .Where(m => m.GetCustomAttributes(typeof(ImportantMethodAttribute), false).Any());

            foreach (var method in methods)
            {
                var attribute = (ImportantMethodAttribute)method.GetCustomAttributes(typeof(ImportantMethodAttribute), false).First();
                Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
            }
        }
    }
}
