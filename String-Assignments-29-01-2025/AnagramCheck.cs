using System;

class AnagramCheck
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();
        bool areAnagrams = CheckIfAnagrams(str1, str2);
        if (areAnagrams){
            Console.WriteLine("The two strings are anagrams.");
        }
        else{
            Console.WriteLine("The two strings are not anagrams.");
        }
    }

    static bool CheckIfAnagrams(string str1, string str2)
    {
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        return new string(arr1) == new string(arr2);
    }
}
