using System;

class NumberCheck
{
    // Method to check whether a number is positive or negative
    public static bool IsPositive(int number){
        return number >= 0;
    }

    // Method to check whether a number is even or odd
    public static bool IsEven(int number){
        return number % 2 == 0;
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2){
        if (number1 > number2){
            return 1;
        }
        else if (number1 == number2){
            return 0;
        }
        else{
            return -1;
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        // Take user input for 5 numbers
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Analyze each number
        Console.WriteLine("Analysis of numbers:");
        for (int i = 0; i < numbers.Length; i++){
            if (IsPositive(numbers[i])){
                Console.Write("Number " + numbers[i] + " is Positive and ");
                if (IsEven(numbers[i])){
                    Console.WriteLine("Even.");
                }
                else{
                    Console.WriteLine("Odd.");
                }
            }
            else{
                Console.WriteLine("Number " + numbers[i] + " is Negative.");
            }
        }

        // Compare the first and last elements of the array
        Console.WriteLine("Comparing the first and last elements:");
        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (comparisonResult == 1){
            Console.WriteLine("The first number (" + numbers[0] + ") is greater than the last number (" + numbers[numbers.Length - 1] + ").");
        }
        else if (comparisonResult == 0){
            Console.WriteLine("The first number (" + numbers[0] + ") is equal to the last number (" + numbers[numbers.Length - 1] + ").");
        }
        else{
            Console.WriteLine("The first number (" + numbers[0] + ") is less than the last number (" + numbers[numbers.Length - 1] + ").");
        }
    }
}
