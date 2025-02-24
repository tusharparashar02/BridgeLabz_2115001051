using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    class Configuration
    {
        private static string API_KEY = "OriginalAPIKey";

        public static void ShowAPIKey() => Console.WriteLine($"API_KEY: {API_KEY}");
    }
    class AccessandModifyStaticFields
    {
        static void Main()
        {
            Type type = typeof(Configuration);
            FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            // Get current value
            Console.WriteLine("Before modification:");
            Configuration.ShowAPIKey();

            // Modify value
            field.SetValue(null, "NewSecureAPIKey");

            // Print modified value
            Console.WriteLine("After modification:");
            Configuration.ShowAPIKey();
        }
    }
}
