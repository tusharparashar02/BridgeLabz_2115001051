using System;
using System.IO;

class UsingStatementforFileHandling
{
    static void Main()
    {
        string filePath = "info.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First line: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
