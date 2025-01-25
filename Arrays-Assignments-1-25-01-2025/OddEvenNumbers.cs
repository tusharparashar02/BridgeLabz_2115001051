using System;

class OddEvenNumbers
{
    static void Main(string[] args)
    {
        // Take user input for the range
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0){
            Console.WriteLine("Invalid number!");
            return;
        }
        // Create arrays to store odd and even numbers
        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;
        // Separate odd and even numbers
        for (int i = 1; i <= number; i++){
            if (i % 2 == 0){
                even[evenIndex++] = i;
            }
            else{
                odd[oddIndex++] = i;
            }
        }
        // Display the odd and even numbers
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++){
            Console.Write(odd[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++){
            Console.Write(even[i] + " ");
        }
    }
}
