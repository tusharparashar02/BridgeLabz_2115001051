using System;

class MultiplicationTableforNumbers6To9
{
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number for the multiplication table: ");
        int number = int.Parse(Console.ReadLine());
        // an array to store results for numbers 6 to 9
        int[] results = new int[4];
        // Cal. the multiplication for each value from 6 to 9
        for (int i = 6; i <= 9; i++){
            results[i - 6] = number * i; 
        }
        // Display the results
        Console.WriteLine("Multiplication Table (6 to 9):");
        for (int i = 6; i <= 9; i++){
            Console.WriteLine(number + " * " + i + " = " + results[i - 6]);
        }
    }
}
