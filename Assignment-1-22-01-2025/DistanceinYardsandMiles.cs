using System;

class DistanceinYardsandMiles {
    public static void Main(string[] args) {
        Console.Write("Enter the distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double yards = feet / 3;
        double miles = yards / 1760;
        Console.WriteLine("The distance in yards is " + yards + " and in miles is " + miles + ".");
    }
}
