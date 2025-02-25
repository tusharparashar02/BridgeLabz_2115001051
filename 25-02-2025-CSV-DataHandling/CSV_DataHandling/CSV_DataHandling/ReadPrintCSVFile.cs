using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_DataHandling
{
    internal class ReadPrintCSVFile
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

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        string[] data = line.Split(',');

                        Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
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
