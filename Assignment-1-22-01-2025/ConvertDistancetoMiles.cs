using System;

class DistanceConverterUserInput {
    public static void Main(string[] args) {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double conversionFactor = 1.6;
        double miles = kilometers / conversionFactor;

        Console.WriteLine("The total miles is " + miles + " miles for the given " + kilometers + " km.");
    }
}
