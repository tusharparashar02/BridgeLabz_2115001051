using System;

class FootballTeam
{
    public static int[] GenerateHeights(int size)
    {
        Random rand = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++){
            heights[i] = rand.Next(150, 251);  
        }

        return heights;
    }
    // Method to find the sum of all elements in the array
    public static int FindSum(int[] heights){
        int sum = 0;
        foreach (int height in heights){
            sum += height;
        }
        return sum;
    }
    // Method to find the mean height
    public static double FindMean(int[] heights){
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }
    // Method to find the shortest height
    public static int FindShortest(int[] heights){
        int shortest = heights[0];
        foreach (int height in heights){
            if (height < shortest){
                shortest = height;
            }
        }
        return shortest;
    }
    // Method to find the tallest height
    public static int FindTallest(int[] heights){
        int tallest = heights[0];
        foreach (int height in heights){
            if (height > tallest){
                tallest = height;
            }
        }
        return tallest;
    }
    static void Main(){
        int[] heights = GenerateHeights(11);  
        // Display the heights of the players
        Console.WriteLine("Heights of the players (in cms):");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        // Calculate and display the shortest, tallest, and mean height
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        double mean = FindMean(heights);

        Console.WriteLine("Shortest height: " + shortest + " cms");
        Console.WriteLine("Tallest height: " + tallest + " cms");
        Console.WriteLine("Mean height: " + mean + " cms");
    }
}
