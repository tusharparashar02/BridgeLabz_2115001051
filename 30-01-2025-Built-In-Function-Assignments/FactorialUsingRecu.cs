using System;

class FactorialUsingRecu{
    static void Main(string[] args){
        Console.Write("Enter a number to calculate its factorial: ");
        int number = int.Parse(Console.ReadLine());
        long result = Factorial(number);
        Console.WriteLine("Factorial of " + number + " is: " + result);
    }
    static long Factorial(int num){
        if (num == 0 || num == 1)
            return 1;
        return num * Factorial(num - 1);
    }
}
