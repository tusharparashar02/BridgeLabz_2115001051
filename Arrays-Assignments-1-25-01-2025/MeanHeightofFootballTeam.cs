using System;

class MeanHeightofFootballTeam
{
    static void Main(string[] args)
    {
        // Create an array to store heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;
        Console.WriteLine("Enter the heights of 11 players:");
        // Take user input for heights
        for (int i = 0; i < 11; i++){
            Console.Write("Height of player " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());
        }
        // Calculate the sum of all heights
        for (int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }
        // Calculate the mean height
        double mean = sum / 11;
        Console.WriteLine("Mean height of the football team: " + mean);
    }
}
