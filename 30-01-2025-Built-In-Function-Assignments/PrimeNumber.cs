using System;

class PrimeNumber{
    static void Main(string[] args){
        Console.Write("Enter a number to check if it's prime: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = IsPrime(number);
        if (isPrime)
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
