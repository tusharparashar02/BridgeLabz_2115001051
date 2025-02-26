using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_DataHandling
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class ConvertCSharpObjIntoJson
    {
        public static void Convert()
        {
            Car car = new Car { Make = "Maruti", Model = "Brezza", Year = 2025 };
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
