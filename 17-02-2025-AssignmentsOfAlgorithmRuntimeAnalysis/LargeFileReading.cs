using System;
using System.Diagnostics;
using System.IO;
class LargeFileReading
{
        public static void Main()
        {
            string filePath = "textfile.txt";

            // Using StreamReader
            Stopwatch sw = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Read() != -1) { }
            }
            sw.Stop();
            Console.WriteLine($"StreamReader Read Time: {sw.Elapsed.TotalMilliseconds}ms");

            // Using FileStream
            sw.Restart();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[8192];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            sw.Stop();
            Console.WriteLine($"FileStream Read Time: {sw.Elapsed.TotalMilliseconds}ms");
        }
    }
