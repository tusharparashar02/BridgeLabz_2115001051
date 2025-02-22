class CensorBadWordsinaSentence
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string pattern = @"\b(damn|stupid)\b";
        string result = Regex.Replace(input, pattern, "****");

        Console.WriteLine(result);
    }
}

