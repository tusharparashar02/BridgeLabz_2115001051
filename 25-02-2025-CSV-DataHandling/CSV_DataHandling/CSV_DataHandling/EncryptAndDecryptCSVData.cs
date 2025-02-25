using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
namespace CSV_DataHandling
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; } 
    }
    class EncryptAndDecryptCSVData
    {
        private static readonly string EncryptionKey = "ThisIsASecretKey"; 

        static void Main()
        {
            string csvFile = "employees_encrypted.csv";
            string decryptedFile = "employees_decrypted.csv";

            // Sample employee data
            List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Tushar Parashar", Email = "Tushar@example.com", Salary = "85000" },
            new Employee { ID = 2, Name = "Tushar Kapoor", Email = "Kapoor@example.com", Salary = "75000" }
        };

            // Encrypt and write data to CSV
            EncryptAndWriteToCsv(employees, csvFile);

            // Read and decrypt data from CSV
            ReadAndDecryptFromCsv(csvFile, decryptedFile);
        }

        static void EncryptAndWriteToCsv(List<Employee> employees, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("ID,Name,Email,Salary"); 

                foreach (var emp in employees)
                {
                    string encryptedEmail = Encrypt(emp.Email);
                    string encryptedSalary = Encrypt(emp.Salary);
                    sw.WriteLine($"{emp.ID},{emp.Name},{encryptedEmail},{encryptedSalary}");
                }
            }

            Console.WriteLine("Encrypted CSV file created successfully!");
        }

        static void ReadAndDecryptFromCsv(string inputFile, string outputFile)
        {
            List<Employee> decryptedEmployees = new List<Employee>();

            using (StreamReader sr = new StreamReader(inputFile))
            {
                sr.ReadLine(); 
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split(',');
                    decryptedEmployees.Add(new Employee
                    {
                        ID = int.Parse(data[0]),
                        Name = data[1],
                        Email = Decrypt(data[2]),
                        Salary = Decrypt(data[3])
                    });
                }
            }

            // Write decrypted data to a new CSV file
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                sw.WriteLine("ID,Name,Email,Salary"); 
                foreach (var emp in decryptedEmployees)
                {
                    sw.WriteLine($"{emp.ID},{emp.Name},{emp.Email},{emp.Salary}");
                }
            }

            Console.WriteLine("Decrypted CSV file created successfully!");
        }

        static string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aes.IV = new byte[16]; 

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encryptedBytes;

                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }

                encryptedBytes = ms.ToArray();
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        static string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aes.IV = new byte[16]; 

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                string decryptedText;

                using (MemoryStream ms = new MemoryStream(encryptedBytes))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    decryptedText = sr.ReadToEnd();
                }

                return decryptedText;
            }
        }
    }
}
