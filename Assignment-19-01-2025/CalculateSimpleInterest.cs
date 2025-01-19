using System;
class CalculateSimpleInterest
{
    static void Main()
    {
        Console.WriteLine("Enter the principal amount:");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the rate of interest:");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the time (in years):");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The simple interest is: " + simpleInterest);
    }
}