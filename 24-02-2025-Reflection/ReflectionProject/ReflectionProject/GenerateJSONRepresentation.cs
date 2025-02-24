using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionProject
{
    class JsonConverter
    {
        public static string ToJson(object obj)
        {
            Type type = obj.GetType();
            StringBuilder json = new StringBuilder("{");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < fields.Length; i++)
            {
                FieldInfo field = fields[i];
                object value = field.GetValue(obj);
                json.Append($"\"{field.Name}\": \"{value}\"");

                if (i < fields.Length - 1) json.Append(", ");
            }

            json.Append("}");
            return json.ToString();
        }
    }

    class Pers
    {
        public string Name = "Alice";
        private int Age = 25;
    }
    class GenerateJSONRepresentation
    {
        static void Main()
        {
            Pers person = new Pers();
            string json = JsonConverter.ToJson(person);
            Console.WriteLine(json); 
        }
    }
}
