using System;
class YoungestandTallestAmongFriends
{
    static void Main(string[] args){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter the age of " + names[i] + ":");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            if (ages[i] <= 0)
            {
                Console.WriteLine("Invalid age. Enter again.");
                i--;
                continue;
            }
            Console.WriteLine("Enter the height (in cm) of " + names[i] + ":");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            if (heights[i] <= 0)
            {
                Console.WriteLine("Invalid height. Enter again.");
                i--;
                continue;
            }
        }
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }
        Console.WriteLine("The youngest friend is " + names[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("The tallest friend is " + names[tallestIndex] + " with height " + heights[tallestIndex] + " cm");
    }
}