class ValidateLicensePlateNumber
{
    static void Main()
    {
        string pattern = @"^[A-Z]{2}\d{4}$";
        string[] testCases = { "AB1234", "A12345", "XY9876", "AB12C3" };

        foreach (var plate in testCases)
        {
            Console.WriteLine($"{plate} → {(Regex.IsMatch(plate, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
