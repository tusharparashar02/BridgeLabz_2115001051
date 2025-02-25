using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    class DetectDuplicatesInCSVFile
    {
        static void Main()
        {
            string filePath = "data.csv";
            HashSet<string> uniqueIds = new HashSet<string>();
            List<string> duplicates = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.ReadLine(); 
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string id = line.Split(',')[0];
                    if (!uniqueIds.Add(id))
                        duplicates.Add(line);
                }
            }

            Console.WriteLine("Duplicate Records:");
            foreach (string record in duplicates)
                Console.WriteLine(record);
        }
    }
}
