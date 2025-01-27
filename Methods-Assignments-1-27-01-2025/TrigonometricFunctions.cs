using System;

class TrigonometricFunctions
{
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = Math.PI * angle / 180.0;
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);
        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter an angle in degrees:");
        double angle = double.Parse(Console.ReadLine());
        double[] trigValues = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sine: {trigValues[0]}, Cosine: {trigValues[1]}, Tangent: {trigValues[2]}");
    }
}