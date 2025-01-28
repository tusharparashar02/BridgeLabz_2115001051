using System;

class NumberChecker{
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

    // Method to check if the number is a duck number (contains a non-zero digit)
    public static bool IsDuckNumber(int[] digits){
        foreach (int digit in digits){
            if (digit != 0){
                return true;
            }
        }
        return false;
    }
    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int[] digits, int number){
        int sum = 0;
        int numberOfDigits = digits.Length;

        foreach (int digit in digits){
            sum += (int)Math.Pow(digit, numberOfDigits);
        }

        return sum == number;
    }
    // Method to find the largest and second largest elements in the digits array
    public static void FindLargestAndSecondLargest(int[] digits, out int largest, out int secondLargest){
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;
        foreach (int digit in digits){
            if (digit > largest){
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit < largest){
                secondLargest = digit;
            }
        }
    }
    // Method to find the smallest and second smallest elements in the digits array
    public static void FindSmallestAndSecondSmallest(int[] digits, out int smallest, out int secondSmallest){
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;

        foreach (int digit in digits){
            if (digit < smallest){
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit > smallest){
                secondSmallest = digit;
            }
        }
    }
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Find the count of digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Count of digits: " + digitCount);
        // Store the digits in an array
        int[] digits = StoreDigits(number);
        // Check if the number is a duck number
        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine("Is Duck Number: " + (isDuck ? "Yes" : "No"));
        // Check if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(digits, number);
        Console.WriteLine("Is Armstrong Number: " + (isArmstrong ? "Yes" : "No"));
        // Find the largest and second largest elements
        FindLargestAndSecondLargest(digits, out int largest, out int secondLargest);
        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Second Largest: " + secondLargest);
        // Find the smallest and second smallest elements
        FindSmallestAndSecondSmallest(digits, out int smallest, out int secondSmallest);
        Console.WriteLine("Smallest: " + smallest);
        Console.WriteLine("Second Smallest: " + secondSmallest);
    }
}
