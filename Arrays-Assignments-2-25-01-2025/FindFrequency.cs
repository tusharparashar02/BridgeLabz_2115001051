using System;

class FindFrequency
{
    static void Main()
    {
        // Input the number
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();

        int[] frequency = new int[10];

        foreach (char digit in number)
        {
            // Check if the character is a digit
            if (char.IsDigit(digit))
            {
                int digitValue = digit - '0'; 
                frequency[digitValue]++;
            }
        }
        // Display the frequency of each digit
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " appears " + frequency[i] + " times.");
            }
        }
    }
}
