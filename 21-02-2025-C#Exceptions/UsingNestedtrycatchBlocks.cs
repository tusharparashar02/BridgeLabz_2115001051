using System;

class UsingNestedtrycatchBlocks
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                int value = numbers[index];

                Console.Write("Enter divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                try
                {
                    int result = value / divisor;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}
