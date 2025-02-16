using System;
using System.IO; 
class StreamReaderReadAFile
{
    static void Main(string[] args)
    {
        string filePath = "file.txt";

        try
        {
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line); 
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
