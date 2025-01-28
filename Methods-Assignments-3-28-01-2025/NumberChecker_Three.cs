using System;

class NumberChecker
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number){
        return number.ToString().Length;
    }

    // Method to store the digits of the number in a digits array
    public static int[] StoreDigits(int number){
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];

        for (int i = 0; i < numberStr.Length; i++){
            digits[i] = int.Parse(numberStr[i].ToString());
        }
        return digits;
    }

    // Method to find the sum of the digits of a number using the digits array
    public static int SumOfDigits(int[] digits){
        int sum = 0;
        foreach (int digit in digits){
            sum += digit;
        }
        return sum;
    }
    // Method to find the sum of the squares of the digits using the digits array
    public static double SumOfSquaresOfDigits(int[] digits){
        double sumOfSquares = 0;
        foreach (int digit in digits){
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }
    // Method to check if the number is a Harshad number (divisible by sum of digits)
    public static bool IsHarshadNumber(int[] digits, int number){
        int sumOfDigits = SumOfDigits(digits);
        return number % sumOfDigits == 0;
    }
    // Method to find the frequency of each digit in the number
    public static void FindDigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2]; 
        // Initialize frequency array with 0
        for (int i = 0; i < 10; i++){
            frequency[i, 0] = i; 
            frequency[i, 1] = 0;  
        }
        // Count the frequency of each digit
        foreach (int digit in digits){
            frequency[digit, 1]++;
        }
        // Display the frequency of each digit
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1]);
            }
        }
    }
    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Count of digits: " + digitCount);

        // Store the digits in an array
        int[] digits = StoreDigits(number);

        // Find the sum of the digits
        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sumOfDigits);

        // Find the sum of the squares of the digits
        double sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        // Check if the number is a Harshad number
        bool isHarshad = IsHarshadNumber(digits, number);
        Console.WriteLine("Is Harshad Number: " + (isHarshad ? "Yes" : "No"));

        // Find and display the frequency of each digit
        FindDigitFrequency(digits);
    }
}
