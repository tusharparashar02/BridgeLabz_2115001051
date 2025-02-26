using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSON_DataHandling
{
    class ParseAndFilterJSON
    {
        static void ParseFilter()
        {
            string json = @"[
            { 'name': 'Tushar', 'age': 20 },
            { 'name': 'Rahul', 'age': 24 },
            { 'name': 'Kapil', 'age': 26 },
            { 'name': 'Dev', 'age': 30 }
            ]";

            JArray jsonArray = JArray.Parse(json);

            var filtered = jsonArray
                .Where(obj => (int)obj["age"] > 25)
                .ToList();

            Console.WriteLine(JArray.FromObject(filtered).ToString());
        }
    }
}
