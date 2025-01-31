using System;

class FibonacciSequence{
    static void Main(string[] args){
        Console.Write("Enter the number of terms for Fibonacci sequence: ");
        int terms = int.Parse(Console.ReadLine());
        GenerateFibonacci(terms);
    }

    static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1, next;
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++){
            if (i <= 1)
                next = i;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
    }
}
