using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    class ReadLargeCSVFile
    {
        static void Main()
        {
            string filePath = "largefile.csv";
            int batchSize = 100;
            int count = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                sr.ReadLine(); 
                string line;
                int batchCount = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    batchCount++;

                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {count} records");
                        batchCount = 0;
                    }
                }
            }

            Console.WriteLine($"Total records processed: {count}");
        }
    }
}
