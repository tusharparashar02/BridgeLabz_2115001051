using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    public class GetClassInformation
    {
        static void Main()
        {
            Console.Write("Enter the class name (e.g., System.String): ");
            string className = Console.ReadLine();

            Type type = Type.GetType(className);
            if (type != null)
            {
                Console.WriteLine($"Class: {type.Name}");
                Console.WriteLine("Methods:");
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine($"- {method.Name}");
                }

                Console.WriteLine("Fields:");
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
                {
                    Console.WriteLine($"- {field.Name}");
                }

                Console.WriteLine("Constructors:");
                foreach (var constructor in type.GetConstructors())
                {
                    Console.WriteLine($"- {constructor.ToString()}");
                }
            }
            else
            {
                Console.WriteLine("Class not found.");
            }
        }
    }
}
