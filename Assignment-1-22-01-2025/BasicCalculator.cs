using System;

class BasicCalculator {
    public static void Main(string[] args) {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Addition: " + (number1 + number2));
        Console.WriteLine("Subtraction: " + (number1 - number2));
        Console.WriteLine("Multiplication: " + (number1 * number2));
        Console.WriteLine("Division: " + (number1 / number2));
    }
}
