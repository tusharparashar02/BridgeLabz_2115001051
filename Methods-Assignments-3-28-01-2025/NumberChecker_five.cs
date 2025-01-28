using System;

class NumberChecker
{
    // Method to check if a number is prime
    public static bool IsPrime(int number){
        if (number <= 1){
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0){
                return false;
            }
        }
        return true;
    }

    // Method to check if a number is a neon number
    public static bool IsNeon(int number){
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0){
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    // Method to check if a number is a spy number
    public static bool IsSpy(int number){
        int sumOfDigits = 0;
        int productOfDigits = 1;
        int temp = number;

        while (temp > 0){
            int digit = temp % 10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            temp /= 10;
        }

        return sumOfDigits == productOfDigits;
    }

    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number){
        int square = number * number;
        while (square > 0){
            if (square % 10 != number % 10){
                return false;
            }
            square /= 10;
            number /= 10;
        }

        return true;
    }

    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number){
        return number % 7 == 0 || number % 10 == 7;
    }

    static void Main(string[] args)
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Check if the number is prime
        bool isPrime = IsPrime(number);
        Console.WriteLine("Is Prime: " + (isPrime ? "Yes" : "No"));
        // Check if the number is a neon number
        bool isNeon = IsNeon(number);
        Console.WriteLine("Is Neon Number: " + (isNeon ? "Yes" : "No"));
        // Check if the number is a spy number
        bool isSpy = IsSpy(number);
        Console.WriteLine("Is Spy Number: " + (isSpy ? "Yes" : "No"));
        // Check if the number is an automorphic number
        bool isAutomorphic = IsAutomorphic(number);
        Console.WriteLine("Is Automorphic Number: " + (isAutomorphic ? "Yes" : "No"));
        // Check if the number is a buzz number
        bool isBuzz = IsBuzz(number);
        Console.WriteLine("Is Buzz Number: " + (isBuzz ? "Yes" : "No"));
    }
}
