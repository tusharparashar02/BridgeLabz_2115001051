using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    class MergeTwoCSVFiles
    {
        static void Main()
        {
            string file1 = "students1.csv";
            string file2 = "students2.csv";
            string outputFile = "merged_students.csv";

            Dictionary<string, string[]> studentData = new Dictionary<string, string[]>();

            using (StreamReader sr = new StreamReader(file1))
            {
                sr.ReadLine(); 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    studentData[data[0]] = data;
                }
            }

            using (StreamReader sr = new StreamReader(file2))
            {
                sr.ReadLine(); 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (studentData.ContainsKey(data[0]))
                    {
                        string[] merged = { data[0], studentData[data[0]][1], studentData[data[0]][2], data[1], data[2] };
                        studentData[data[0]] = merged;
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                sw.WriteLine("ID,Name,Age,Marks,Grade");
                foreach (var entry in studentData.Values)
                    sw.WriteLine(string.Join(",", entry));
            }

            Console.WriteLine("Merged CSV created successfully.");
        }
    }
}
