class ValidateanIPAddress
{
    static void Main()
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";
        string[] testCases = { "192.168.1.1", "255.255.255.255", "256.100.50.25", "10.10.10" };

        foreach (var ip in testCases)
        {
            Console.WriteLine($"{ip} → {(Regex.IsMatch(ip, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
