using System;
using System.IO; 
class StreamReaderCountTheOccurence
{
    static void Main()
    {
        string filePath = "file.txt";
        string wordToFind = "example";
        try
        {
            StreamReader reader = new StreamReader(filePath);
            int wordCount = 0; 
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (word.ToLower() == wordToFind.ToLower())
                    {
                        wordCount++;
                    }
                }
            }
            reader.Close();
            Console.WriteLine("The word" + wordToFind + "appears" + wordCount +"times in the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}