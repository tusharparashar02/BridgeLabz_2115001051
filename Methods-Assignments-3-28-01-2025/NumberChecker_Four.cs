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

    // Method to reverse the digits array
    public static int[] ReverseDigits(int[] digits){
        Array.Reverse(digits);
        return digits;
    }

    // Method to compare two arrays and check if they are equal
    public static bool CompareArrays(int[] arr1, int[] arr2){
        if (arr1.Length != arr2.Length){
            return false;
        }
        for (int i = 0; i < arr1.Length; i++){
            if (arr1[i] != arr2[i]){
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int[] digits){
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());  
        return CompareArrays(digits, reversedDigits);
    }

    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int[] digits){
        foreach (int digit in digits){
            if (digit != 0){
                return true;
            }
        }
        return false;
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
        // Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(digits);
        Console.WriteLine("Is Palindrome: " + (isPalindrome ? "Yes" : "No"));
        // Check if the number is a duck number
        bool isDuckNumber = IsDuckNumber(digits);
        Console.WriteLine("Is Duck Number: " + (isDuckNumber ? "Yes" : "No"));
    }
}
