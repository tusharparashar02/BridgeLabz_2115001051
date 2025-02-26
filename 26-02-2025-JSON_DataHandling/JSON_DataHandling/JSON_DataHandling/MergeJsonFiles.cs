using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON_DataHandling
{
    class MergeJsonFiles
    {
        public static void MergeJson(string file1, string file2, string outputFile)
        {
            JObject json1 = JObject.Parse(File.ReadAllText(file1));
            JObject json2 = JObject.Parse(File.ReadAllText(file2));

            json1.Merge(json2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            File.WriteAllText(outputFile, json1.ToString());
            Console.WriteLine("Merged JSON saved to " + outputFile);
        }
    }
}
