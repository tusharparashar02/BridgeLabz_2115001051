using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    class ModifyCSVFile
    {
        static void Main()
        {
            string filePath = "employees.csv";
            string newFilePath = "updatedEmployees.csv";
            List<string> updatedRecords = new List<string>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            updatedRecords.Add(line);
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(',');

                        if (data[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            double salary = double.Parse(data[3]);
                            salary *= 1.10;  
                            data[3] = salary.ToString("F2");
                        }

                        updatedRecords.Add(string.Join(",", data));
                    }
                }

                File.WriteAllLines(newFilePath, updatedRecords);
                Console.WriteLine("Updated salaries saved to updatedEmployees.csv");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
