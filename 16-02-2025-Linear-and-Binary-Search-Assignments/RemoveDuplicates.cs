using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static string RemoveDuplicates(string input)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = RemoveDuplicates(input);
        Console.WriteLine("String without duplicates: " + result);
    }
}
