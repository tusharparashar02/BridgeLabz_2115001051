using System;
using System.IO;

class ReadandWriteaTextFile
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fsRead))
            using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fsWrite))
            {
                string content = reader.ReadToEnd();
                writer.Write(content);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
