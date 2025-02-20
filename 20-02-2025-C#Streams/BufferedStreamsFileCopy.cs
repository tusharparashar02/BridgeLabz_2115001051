using System;
using System.Diagnostics;
using System.IO;

class BufferedStreamsFileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.txt";
        string destinationFile1 = "copy_unbuffered.txt";
        string destinationFile2 = "copy_buffered.txt";

        Stopwatch stopwatch = new Stopwatch();

        // Unbuffered Copy
        stopwatch.Start();
        using (FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream dest = new FileStream(destinationFile1, FileMode.Create, FileAccess.Write))
        {
            source.CopyTo(dest);
        }
        stopwatch.Stop();
        Console.WriteLine("Unbuffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Buffered Copy
        stopwatch.Restart();
        using (FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream dest = new FileStream(destinationFile2, FileMode.Create, FileAccess.Write))
        using (BufferedStream buffer = new BufferedStream(dest, 4096))
        {
            byte[] data = new byte[4096];
            int bytesRead;
            while ((bytesRead = source.Read(data, 0, data.Length)) > 0)
            {
                buffer.Write(data, 0, bytesRead);
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Buffered Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
