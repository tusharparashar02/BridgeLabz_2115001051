using System;
using System.IO;
class ConvertUppercasetoLowercase
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string destinationFile = "converted.txt";

        try
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream))
            using (StreamReader reader = new StreamReader(bufferedSource))
            using (FileStream destStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedDest = new BufferedStream(destStream))
            using (StreamWriter writer = new StreamWriter(bufferedDest))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("Conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
