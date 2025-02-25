using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

namespace CSV_DataHandling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class ConvertJSONtoCSV
    {
        static void Main()
        {
            string jsonPath = "students.json";
            string csvPath = "students.csv";
            string outputJsonPath = "students_output.json";

            // Convert JSON to CSV
            ConvertJsonToCsv(jsonPath, csvPath);

            // Convert CSV back to JSON
            ConvertCsvToJson(csvPath, outputJsonPath);
        }

        static void ConvertJsonToCsv(string jsonFile, string csvFile)
        {
            var students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(jsonFile));

            using (StreamWriter sw = new StreamWriter(csvFile))
            {
                sw.WriteLine("ID,Name,Age"); 
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.ID},{student.Name},{student.Age}");
                }
            }

            Console.WriteLine("JSON converted to CSV successfully!");
        }

        static void ConvertCsvToJson(string csvFile, string jsonFile)
        {
            var students = new List<Student>();

            using (StreamReader sr = new StreamReader(csvFile))
            {
                sr.ReadLine(); 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    students.Add(new Student
                    {
                        ID = int.Parse(data[0]),
                        Name = data[1],
                        Age = int.Parse(data[2])
                    });
                }
            }

            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(students, Formatting.Indented));
            Console.WriteLine("CSV converted back to JSON successfully!");
        }
    }
}

