using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    class Person
    {
        private int age = 21;
    }
    public class AccessPrivateField
    {
        static void Main()
        {
            Person person = new Person();
            Type type = typeof(Person);

            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            // Get value
            int ageValue = (int)field.GetValue(person);
            Console.WriteLine($"Original Age: {ageValue}");

            // Set new value
            field.SetValue(person, 30);
            Console.WriteLine($"Modified Age: {field.GetValue(person)}");
        }
    }
}
