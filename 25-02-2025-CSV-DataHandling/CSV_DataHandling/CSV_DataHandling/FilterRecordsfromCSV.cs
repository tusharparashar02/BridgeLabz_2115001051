using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    public class FilterRecordsfromCSV
    {
        static void Main()
        {
            string filePath = "students.csv";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    Console.WriteLine("Students with marks > 80:");

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(',');

                        if (int.Parse(data[3]) > 80)
                        {
                            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
