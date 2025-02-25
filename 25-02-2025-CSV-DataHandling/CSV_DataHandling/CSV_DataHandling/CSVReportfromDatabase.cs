using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_DataHandling
{
    class CSVReportfromDatabase
    {
        static void Main()
        {
            string connString = "YourConnectionString";
            string filePath = "EmployeeReport.csv";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Employee ID,Name,Department,Salary");

                    while (reader.Read())
                    {
                        sw.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]}");
                    }
                }
            }

            Console.WriteLine("CSV report generated successfully.");
        }
    }
}
