using System;
class RemoveCharacter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter character to remove:");
        char charToRemove = Console.ReadLine()[0];
        string modifiedString = RemoveCharacterFromString(input, charToRemove);
        
        Console.WriteLine("Modified String: " + modifiedString);
    }

    static string RemoveCharacterFromString(string input, char charToRemove)
    {
        return input.Replace(charToRemove.ToString(), "");
    }
}
