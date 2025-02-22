class ValidateSocialSecurityNumber
{
    static void Main()
    {
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        string[] testCases = { "123-45-6789", "123456789", "987-65-4321", "12-345-6789" };

        foreach (var ssn in testCases)
        {
            Console.WriteLine($"{ssn} → {(Regex.IsMatch(ssn, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
