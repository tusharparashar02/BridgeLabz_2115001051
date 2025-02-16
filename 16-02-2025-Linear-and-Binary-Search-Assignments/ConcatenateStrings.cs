using System;
using System.Text;

class Program
{
    static string ConcatenateStrings(string[] words)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word);
            sb.Append(" "); 
        }
        return sb.ToString().TrimEnd(); 
    }
    static void Main()
    {
        string[] words = { "Tushar", "is", "a", "Good", "Boy" };
        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated String: " + result);
    }
}
