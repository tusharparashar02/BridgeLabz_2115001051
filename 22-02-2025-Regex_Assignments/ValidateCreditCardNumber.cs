using System;
using System.Text.RegularExpressions;

class ValidateCreditCardNumber
{
    static void Main()
    {
        string pattern = @"^(4\d{15}|5\d{15})$";
        string[] testCases = { "4111111111111111", "5123456789012345", "6111111111111111", "4111-1111-1111-1111" };

        foreach (var card in testCases)
        {
            Console.WriteLine($"{card} → {(Regex.IsMatch(card, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
