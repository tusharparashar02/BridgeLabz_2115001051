using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JSON_DataHandling
{
    class ConvertCSVtoJSON
    {
        public static void Convert(string csvFilePath, string jsonFilePath)
        {
            var lines = File.ReadAllLines(csvFilePath);
            var headers = lines[0].Split(',');

            var list = new List<Dictionary<string, string>>();
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var obj = new Dictionary<string, string>();
                for (int j = 0; j < headers.Length; j++)
                {
                    obj[headers[j]] = values[j];
                }
                list.Add(obj);
            }

            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            Console.WriteLine("CSV converted to JSON successfully.");
        }
    }
}
