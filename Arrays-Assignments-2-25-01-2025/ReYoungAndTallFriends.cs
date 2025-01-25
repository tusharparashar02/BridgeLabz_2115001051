using System;

class YoungestAndTallestAmongFriends
{
    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input ages and heights for the three friends
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

        // Determine the youngest and tallest friends
        for (int i = 1; i < 3; i++){
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }
        Console.WriteLine("The youngest friend is " + names[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("The tallest friend is " + names[tallestIndex] + " with height " + heights[tallestIndex] + " cm");
        
        // Dynamic array resizing and finding the largest and second-largest digits in a number
        Console.WriteLine("Enter a number to find the largest and second-largest digits:");
        string input = Console.ReadLine();
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
        foreach (char c in input){
            if (index == maxDigit){
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }
            digits[index] = c - '0';
            index++;
        }
        if (index < 2){
            Console.WriteLine("Number must have at least two digits.");
            return;
        }
        // Finding the largest and second-largest digits
        int largest = -1, secondLargest = -1;

        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
        Console.WriteLine("The largest digit is: " + largest);
        Console.WriteLine("The second-largest digit is: " + secondLargest);
    }
}
