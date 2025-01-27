using System;

class QuotientAndReminder
{
    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }

    static void Main(string[] args){
        Console.WriteLine("Enter number and divisor:");
        int number = int.Parse(Console.ReadLine());
        int divisor = int.Parse(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
}