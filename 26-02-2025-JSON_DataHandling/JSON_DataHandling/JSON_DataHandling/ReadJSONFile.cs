using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON_DataHandling
{
    class ReadJSONFile
    {
        public static void ReadAndPrintKeys(string filePath)
        {
            string json = File.ReadAllText(filePath);
            JObject obj = JObject.Parse(json);

            Console.WriteLine("JSON Keys and Values:");
            foreach (var item in obj)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
