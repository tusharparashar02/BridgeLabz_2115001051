class FindRepeatingWords
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}
