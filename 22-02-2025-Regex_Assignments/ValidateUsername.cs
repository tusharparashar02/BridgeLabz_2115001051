using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main()
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        string[] testCases = { "user_123", "123user", "us", "validUser99", "_invalid" };

        foreach (var username in testCases)
        {
            Console.WriteLine($"{username} → {(Regex.IsMatch(username, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
