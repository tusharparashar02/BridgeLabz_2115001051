using System;

class SumofNumbersUntil
{
    static void Main(string[] args)
    {
        // Declare an array to store up to 10 numbers
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;
        Console.WriteLine("Enter numbers (enter 0 or negative to stop):");
        // Take user input until 0 or negative number is entered
        while (true){
            double num = double.Parse(Console.ReadLine());
            if (num <= 0 || index == 10){
                break; 
            }
            numbers[index] = num;
            index++;
        }
        // Calculate the total sum
        for (int i = 0; i < index; i++){
            total += numbers[i];
        }
        // Display all numbers and the total sum
        Console.WriteLine("Numbers entered:");
        for (int i = 0; i < index; i++){
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine("Total sum: " + total);
    }
}
