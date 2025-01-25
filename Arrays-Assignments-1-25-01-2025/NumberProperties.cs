using System;
class NumberProperties
{
    static void Main(string[] args)
    {
        // Declare an array to store 5 numbers
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        // user input for all numbers
        for (int i = 0; i < numbers.Length; i++){
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        // Check the properties of each number
        for (int i = 0; i < numbers.Length; i++){
            if (numbers[i] > 0){
                Console.WriteLine(numbers[i] + " is positive");
                // Check if the number is even or odd
                if (numbers[i] % 2 == 0){
                    Console.WriteLine(numbers[i] + " is even");
                }
                else{
                    Console.WriteLine(numbers[i] + " is odd");
                }
            }
            else if (numbers[i] < 0){
                Console.WriteLine(numbers[i] + " is negative");
            }
            else{
                Console.WriteLine(numbers[i] + " is zero");
            }
        }
        // Compare the first and last elements of the array
        if (numbers[0] == numbers[numbers.Length - 1]){
            Console.WriteLine("First and last numbers are equal");
        }
        else if (numbers[0] > numbers[numbers.Length - 1]){
            Console.WriteLine("First number is greater than the last number");
        }
        else{
            Console.WriteLine("First number is less than the last number");
        }
    }
}
