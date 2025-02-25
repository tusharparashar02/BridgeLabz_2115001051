using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSV_DataHandling
{
    public class WriteDataCSVFile
    {
        static void Main()
        {
            string filePath = "employees.csv";

            string[] employees = {
            "ID,Name,Department,Salary",
            "1,Tushar Parashar,IT,100000",
            "2,Tushar Gupta,HR,55000",
            "3,Tushar Kapoor,Finance,90000",
            "4,Tushar Mehra,Marketing,60000",
            "5,Tushar Arora,Operations,67800"
        };

            File.WriteAllLines(filePath, employees);

            Console.WriteLine("Employee data written successfully.");
        }
    }
}

