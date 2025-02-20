using System;
using System.IO;

class ConvertImageToByteArray
{
    static void Main()
    {
        string sourceImage = "input.jpg";
        string destinationImage = "output.jpg";

        try
        {
            // Convert Image to Byte Array
            byte[] imageData = File.ReadAllBytes(sourceImage);

            // Write Byte Array back to File
            File.WriteAllBytes(destinationImage, imageData);

            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
