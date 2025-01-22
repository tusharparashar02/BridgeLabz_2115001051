using System;

class PoundsToKilograms {
    public static void Main(string[] args) {
        Console.WriteLine("Enter weight in pounds:");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds / 2.2;

        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kilograms);
    }
}
