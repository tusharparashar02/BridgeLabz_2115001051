using System;

class HandlingMultipleExceptions
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter index number: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        }
    }
}
