using System;
class BasicCalculator{
    static void Main(string[] args){
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Choose an operation (1-4): ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double result = 0;
        bool valid = true;
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                if (num2 == 0){
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    valid = false;
                }
                else{
                    result = Divide(num1, num2);
                }
                break;
            default:
                Console.WriteLine("Invalid choice!");
                valid = false;
                break;
        }
        if (valid)
            Console.WriteLine("Result: " + result);
    }
    static double Add(double a, double b){
        return a + b;
    }

    static double Subtract(double a, double b){
        return a - b;
    }

    static double Multiply(double a, double b){
        return a * b;
    }

    static double Divide(double a, double b){
        return a / b;
    }
}