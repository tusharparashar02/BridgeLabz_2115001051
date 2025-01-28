using System;

class NumberChecker
{
    // Method to find factors of a number and return them as an array
    public static int[] FindFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index++] = i;
            }
        }

        return factors;
    }

    // Method to find the greatest factor of a number using the factors array
    public static int FindGreatestFactor(int[] factors){
        return factors[factors.Length - 1];
    }

    // Method to find the sum of the factors using the factors array
    public static int FindSumOfFactors(int[] factors){
        int sum = 0;
        foreach (int factor in factors){
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors using the factors array
    public static int FindProductOfFactors(int[] factors){
        int product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }

    // Method to find the product of the cube of the factors using the factors array
    public static double FindProductOfCubeOfFactors(int[] factors){
        double product = 1;
        foreach (int factor in factors){
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    // Method to check if a number is a perfect number
    public static bool IsPerfectNumber(int number){
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
        return sum == number;
    }

    // Method to check if a number is an abundant number
    public static bool IsAbundantNumber(int number){
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
        return sum > number;
    }

    // Method to check if a number is a deficient number
    public static bool IsDeficientNumber(int number){
        int[] factors = FindFactors(number);
        int sum = FindSumOfFactors(factors) - number; // Exclude the number itself
        return sum < number;
    }

    // Method to check if a number is a strong number
    public static bool IsStrongNumber(int number){
        int sum = 0;
        int temp = number;

        while (temp > 0){
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        return sum == number;
    }
    // Helper method to calculate the factorial of a number
    public static int Factorial(int n){
        int result = 1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Find the factors of the number
        int[] factors = FindFactors(number);
        // Display the factors
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));
        // Find and display the greatest factor
        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest factor: " + greatestFactor);
        // Find and display the sum of the factors
        int sumOfFactors = FindSumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sumOfFactors);
        // Find and display the product of the factors
        int productOfFactors = FindProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + productOfFactors);
        // Find and display the product of the cube of the factors
        double productOfCubeOfFactors = FindProductOfCubeOfFactors(factors);
        Console.WriteLine("Product of cube of factors: " + productOfCubeOfFactors);
        // Check and display if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + (isPerfect ? "Yes" : "No"));
        // Check and display if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + (isAbundant ? "Yes" : "No"));
        // Check and display if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + (isDeficient ? "Yes" : "No"));
        // Check and display if the number is a strong number
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + (isStrong ? "Yes" : "No"));
    }
}
