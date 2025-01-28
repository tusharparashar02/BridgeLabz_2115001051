using System;

public class AmarAkbarAnthoni
{
    public static int FindYoungest(int[] ages){
        int youngest = ages[0];
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < youngest){
                youngest = ages[i];
            }
        }
        return youngest;
    }
    public static int FindTallest(int[] heights){
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > tallest){
                tallest = heights[i];
            }
        }
        return tallest;
    }
    public static void Main(){
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++){
            Console.WriteLine("Enter the age of friend " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of friend " + (i + 1) + ": ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Youngest age: " + FindYoungest(ages));
        Console.WriteLine("Tallest height: " + FindTallest(heights));
    }
}
