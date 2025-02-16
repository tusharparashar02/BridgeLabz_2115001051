using System;
using System.IO;
class ReadUserInput
{
    static void Main()
    {
        string filePath = "userinput.txt";

        Console.WriteLine("Enter text to save to the file");

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (true)
                {
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "exit") break;

                    writer.WriteLine(userInput);
                }
            }

            Console.WriteLine("User input has been saved to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}