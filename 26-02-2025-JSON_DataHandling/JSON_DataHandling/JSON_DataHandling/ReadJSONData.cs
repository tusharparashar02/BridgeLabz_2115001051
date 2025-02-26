using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;


namespace JSON_DataHandling
{
    internal class ReadJSONData
    {
        static void Read()
        {
            string json = File.ReadAllText("data.json");  
            JObject obj = JObject.Parse(json);

            string name = obj["name"]?.ToString();
            string email = obj["email"]?.ToString();

            Console.WriteLine($"Name: {name}, Email: {email}");
        }
    }
}
