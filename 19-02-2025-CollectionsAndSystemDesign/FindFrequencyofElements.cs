using System;
using System.Collections.Generic;
class FindFrequencyofElements
{
    static Dictionary<string, int> GetFrequency(List<string> list)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (var item in list)
        {
            if (frequency.ContainsKey(item))
                frequency[item]++;
            else
                frequency[item] = 1;
        }
        return frequency;
    }

    static void Main()
    {
        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
        var result = GetFrequency(items);
        
        foreach (var kvp in result)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
