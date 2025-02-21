using System;

class DemonstratingfinallyBlockExecution
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
