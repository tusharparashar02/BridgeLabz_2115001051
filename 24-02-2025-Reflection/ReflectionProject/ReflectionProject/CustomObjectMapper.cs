using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    class ObjectMapper
    {
        public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);

            foreach (var prop in properties)
            {
                FieldInfo field = type.GetField(prop.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (field != null)
                {
                    field.SetValue(obj, Convert.ChangeType(prop.Value, field.FieldType));
                }
            }
            return obj;
        }
    }

    class Persons
    {
        public string Name;
        private int Age;

        public void ShowDetails() => Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
    class CustomObjectMapper
    {
        static void Main()
        {
            Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "Name", "John Doe" },
            { "Age", 30 }
        };

            Persons person = ObjectMapper.ToObject<Persons>(data);
            person.ShowDetails(); // Output: Name: John Doe, Age: 30
        }
    }
}
