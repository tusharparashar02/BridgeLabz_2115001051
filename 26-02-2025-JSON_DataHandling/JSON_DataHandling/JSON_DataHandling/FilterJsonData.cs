using System;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JSON_DataHandling
{
    class FilterJsonData
    {
        public static void FilterUsers(string filePath)
        {
            string json = File.ReadAllText(filePath);
            JArray users = JArray.Parse(json);

            Console.WriteLine("Users older than 25:");
            foreach (JObject user in users)
            {
                if ((int)user["age"] > 25)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
