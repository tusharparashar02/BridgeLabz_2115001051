using System;
class PowerCalculation
{
    static void Main()
    {
        Console.WriteLine("Enter the base:");
        double baseNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the exponent:");
        double exponent = Convert.ToDouble(Console.ReadLine());
        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine(baseNumber + " raised to the power of " + exponent + " is: " + result);
    }
}
