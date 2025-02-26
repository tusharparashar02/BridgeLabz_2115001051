using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSON_DataHandling
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class ConvertList
    {
        public static void Convert()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Tushar", Age = 20 },
                new Person { Name = "Rahul", Age = 35 }
            };

            string jsonArray = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine(jsonArray);
        }
    }
}
