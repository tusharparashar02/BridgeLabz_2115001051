using System;
using System.IO;

class StoreandRetrievePrimitiveData
{
    static void Main()
    {
        string filePath = "students.txt";
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(101); 
                writer.Write("Tushar"); 
                writer.Write(8.8); 

                writer.Write(102);
                writer.Write("Parashar");
                writer.Write(6.5);
            }
            Console.WriteLine("Data written successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine($"Roll: {roll}, Name: {name}, GPA: {gpa}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
