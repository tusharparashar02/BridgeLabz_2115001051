using System;

class FindFactorsofaNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The factors of " + number + " are:");
        int[] factors = new int[100]; // Large array for simplicity
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
            {
                factors[count] = i; // Store the factor
                count++;
            }
        }
        for (int j = 0; j < count; j++){
            Console.WriteLine(factors[j]); // Display factors
        }
    }
}
