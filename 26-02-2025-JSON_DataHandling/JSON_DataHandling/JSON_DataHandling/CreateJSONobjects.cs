using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_DataHandling
{
   class CreateJSONobjects
    {
        public static void ObjectCreactions()
        {
            var student = new
            {
                Name = "Tushar Parashar",
                Age = 20,
                Subjects = new string[] { "Math", "Physics", "Chemistry" }
            };

            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
