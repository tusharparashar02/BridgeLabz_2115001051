using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    public class ReadAndCountRows
    {
        static void Main()
        {
            string filePath = "employees.csv";
            int count = 0;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();  

                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                }

                Console.WriteLine("Total Count "+ count);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
