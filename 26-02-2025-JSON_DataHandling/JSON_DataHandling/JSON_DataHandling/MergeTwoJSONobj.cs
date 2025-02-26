using System;
using Newtonsoft.Json.Linq;
namespace JSON_DataHandling
{
    class MergeTwoJSONobj
    {
        static void MergeObj()
        {
            string json1 = "{ \"name\": \"Tushar\", \"age\": 21 }";
            string json2 = "{ \"city\": \"Mathura\", \"email\": \"tushar@gla.com\" }";

            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            obj1.Merge(obj2);

            Console.WriteLine(obj1.ToString());
        }
    }
}
