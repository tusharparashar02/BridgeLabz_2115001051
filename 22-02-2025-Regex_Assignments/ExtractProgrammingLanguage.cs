class ExtractProgrammingLanguage
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(JavaScript|Java|Python|Go|C\+\+|C#|Ruby|PHP|Swift|Kotlin)\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.Write(match.Value + ", ");
        }
    }
}
