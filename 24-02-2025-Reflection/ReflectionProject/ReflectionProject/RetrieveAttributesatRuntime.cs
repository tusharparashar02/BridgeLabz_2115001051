using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    class RetrieveAttributesatRuntime
    {
        // Define custom attribute
        [AttributeUsage(AttributeTargets.Class)]
        class AuthorAttribute : Attribute
        {
            public string Name { get; }
            public AuthorAttribute(string name) => Name = name;
        }

        // Apply attribute to a class
        [Author("Tushar Parashar")]
        class SampleClass { }
        static void Main()
        {
            Type type = typeof(SampleClass);
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            if (attributes.Length > 0)
            {
                AuthorAttribute author = (AuthorAttribute)attributes[0];
                Console.WriteLine($"Author: {author.Name}");
            }
            else
            {
                Console.WriteLine("No Author attribute found!");
            }
        }
    }
}
