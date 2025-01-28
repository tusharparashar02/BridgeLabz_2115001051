using System;

class SumNaturalNumbers
{
    public static void Main(string[] args){
        Console.Write("Enter a natural number (positive integer): ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("The input is not a natural no Exiting");
            return;
        }
        // Sum using recursion
        int sumRecursive = FindSumRecursive(n);
        Console.WriteLine("Sum using recursion: " + sumRecursive);

        // Sum using formula
        int sumFormula = FindSumFormula(n);
        Console.WriteLine("Sum using formula: " + sumFormula);

        // Comparing results
        if (sumRecursive == sumFormula){
            Console.WriteLine("Both methods produce the same result!");
        }
        else{
            Console.WriteLine("The results differ something is wrong.");
        }
    }

    // Recursive method to calculate the sum of n natural numbers
    public static int FindSumRecursive(int n){
        if (n == 1){
          return 1;  
        } 
        return n + FindSumRecursive(n - 1); 
    }

    // method to cal. the sum of n natural numbers using the formula
    public static int FindSumFormula(int n){
        return n * (n + 1) / 2;
    }
}
