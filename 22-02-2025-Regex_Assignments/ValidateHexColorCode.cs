class ValidateHexColorCode
{
    static void Main()
    {
        string pattern = @"^#([A-Fa-f0-9]{6})$";
        string[] testCases = { "#FFA500", "#ff4500", "#123", "#ABCDEF", "#000000" };

        foreach (var color in testCases)
        {
            Console.WriteLine($"{color} → {(Regex.IsMatch(color, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
