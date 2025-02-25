using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace CSV_DataHandling
{
    class ValidateCSVData
    {
        static void Main()
        {
            string filePath = "contacts.csv"; 
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d{10}$";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader) { isHeader = false; continue; }

                        string[] data = line.Split(',');

                        if (!Regex.IsMatch(data[2], emailPattern))
                            Console.WriteLine($"Invalid Email: {line}");

                        if (!Regex.IsMatch(data[3], phonePattern))
                            Console.WriteLine($"Invalid Phone Number: {line}");
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
