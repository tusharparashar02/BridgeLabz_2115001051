using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class CountWordsinaFile
{
    static void Main()
    {
        string filePath = "textfile.txt";
        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string word in Regex.Split(line.ToLower(), @"\W+"))
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (wordCounts.ContainsKey(word))
                                wordCounts[word]++;
                            else
                                wordCounts[word] = 1;
                        }
                    }
                }
            }

            var topWords = wordCounts.OrderByDescending(kvp => kvp.Value).Take(5);
            Console.WriteLine("Top 5 Words:");
            foreach (var kvp in topWords)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
