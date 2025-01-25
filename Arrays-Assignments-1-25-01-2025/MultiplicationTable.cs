using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number for the multiplication table: ");
        int number = int.Parse(Console.ReadLine());
        // Create an array to store results of multiplication
        int[] results = new int[10];
        // Calculate the table and store in the array
        for (int i = 0; i < 10; i++)
        {
            results[i] = number * (i + 1);
        }
        // Display the multiplication table
        Console.WriteLine("Multiplication Table:");
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine(number + " * " + (i + 1) + " = " + results[i]);
        }
    }
}
