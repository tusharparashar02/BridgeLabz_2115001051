using System;
using System.IO;

class FileNotFoundException
{
    static void Main()
    {
        string filePath = "file.txt";

        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:" + content);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
