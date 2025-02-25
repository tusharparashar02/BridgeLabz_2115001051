using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV_DataHandling
{
    public class SearchRecordInCSV
    {
        static void Main()
        {
            string filePath = "employees.csv";
            Console.Write("Enter employee name to search: ");
            string searchName = Console.ReadLine();

            bool found = false;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    sr.ReadLine(); 

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Employee Found: Department - {data[2]}, Salary - {data[3]}");
                            found = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
