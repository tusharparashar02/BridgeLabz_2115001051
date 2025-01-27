using System;

class AthleteRounds
{
    public static int CalculateRounds(double side1, double side2, double side3){
        double perimeter = side1 + side2 + side3;
        return (int)Math.Ceiling(5000 / perimeter);
    }

    static void Main(string[] args){
        Console.WriteLine("Enter three sides of the triangular park (in meters):");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Rounds Required: " + CalculateRounds(side1, side2, side3));
    }
}