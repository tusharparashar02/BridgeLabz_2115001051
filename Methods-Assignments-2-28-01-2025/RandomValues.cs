using System;

class RandomValues
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size){
        Random random = new Random();
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Ensures 4-digit numbers
        }
        return numbers;
    }

    // Method to find average, min, and max of an array
    public static double[] FindAverageMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++){
            if (numbers[i] < min){
                min = numbers[i];
            }
            if (numbers[i] > max){
                max = numbers[i];
            }
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }

    static void Main(string[] args){
        int size = 5; // No. of random values
        int[] randomNumbers = Generate4DigitRandomArray(size);
        // Display generated numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        for (int i = 0; i < randomNumbers.Length; i++){
            Console.WriteLine(randomNumbers[i]);
        }
        // Calculate statistics
        double[] stats = FindAverageMinMax(randomNumbers);
        // Display statistics
        Console.WriteLine("Average value: " + stats[0]);
        Console.WriteLine("Minimum value: " + stats[1]);
        Console.WriteLine("Maximum value: " + stats[2]);
    }
}
