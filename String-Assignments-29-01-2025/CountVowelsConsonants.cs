using System;
class CountVowelsConsonants
{
    static void Main(string[] args){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine().ToLower();
        int vowelCount = CountVowels(str);
        int consonantCount = CountConsonants(str);
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if ("aeiou".Contains(c.ToString()))
                count++;
        }
        return count;
    }

    static int CountConsonants(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (char.IsLetter(c) && !"aeiou".Contains(c.ToString()))
                count++;
        }
        return count;
    }

}