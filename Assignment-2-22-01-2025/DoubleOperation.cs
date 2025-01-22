using System;

class DoubleOperation {
    public static void Main(string[] args) {
        Console.WriteLine("Enter three double values a, b, and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;

        Console.WriteLine("The results of Double Operations are " + result1 + ", " + result2 + ", and " + result3);
    }
}
