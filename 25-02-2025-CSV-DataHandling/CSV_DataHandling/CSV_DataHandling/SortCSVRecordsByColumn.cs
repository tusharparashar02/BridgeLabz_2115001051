using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    class SortCSVRecordsByColumn
    {
        static void Main()
        {
            string filePath = "employees.csv";
            List<string[]> records = new List<string[]>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string header = sr.ReadLine();
                    Console.WriteLine("Top 5 highest paid employees:");

                    while (!sr.EndOfStream)
                    {
                        string[] data = sr.ReadLine().Split(',');
                        records.Add(data);
                    }
                }

                var sortedRecords = records.OrderByDescending(r => double.Parse(r[3])).Take(5);

                foreach (var record in sortedRecords)
                {
                    Console.WriteLine($"ID: {record[0]}, Name: {record[1]}, Department: {record[2]}, Salary: {record[3]}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
