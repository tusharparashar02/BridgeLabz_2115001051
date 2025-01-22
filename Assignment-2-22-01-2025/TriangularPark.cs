using System;

class TriangularPark {
    public static void Main(string[] args) {
        Console.WriteLine("Enter the three sides of the triangular park in meters:");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(rounds) + " to complete 5 km");
    }
}
