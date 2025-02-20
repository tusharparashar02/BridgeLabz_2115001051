using System;
using System.IO;

class ReadUserInputfromConsole.cs
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your Address: ");
        string language = Console.ReadLine();

        string filePath = "user_data.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Address " + language);
            }

            Console.WriteLine("User data saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
