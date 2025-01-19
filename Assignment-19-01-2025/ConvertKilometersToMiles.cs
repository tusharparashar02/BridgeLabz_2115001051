using System;
class ConvertKilometersToMiles
{
    static void Main()
    {
        Console.WriteLine("Enter the distance in kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine(kilometers + " kilometers is equal to " + miles + " miles.");
    }
}
