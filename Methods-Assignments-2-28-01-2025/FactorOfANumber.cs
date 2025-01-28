using System;
class FactorOfANumber{
    public static void Main(string[] args){
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors of the number:");
        foreach (int factor in factors){
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Sum of factors: " + FindSum(factors));
        Console.WriteLine("Sum of squares of factors: " + FindSumOfSquares(factors));
        Console.WriteLine("Product of factors: " + FindProduct(factors));
    }
    public static int[] FindFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }
        int[] factors = new int[count];
        // Second loop to store factors
        int index = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }
    public static int FindSum(int[] factors){
        int sum = 0;
        foreach (int factor in factors){
            sum += factor;
        }
        return sum;
    }

    public static int FindSumOfSquares(int[] factors){
        int sumOfSquares = 0;
        foreach (int factor in factors){
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
    public static int FindProduct(int[] factors){
        int product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }
}
