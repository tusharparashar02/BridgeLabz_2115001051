using System;

class HeightConversion {
    public static void Main(string[] args) {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double heightInches = heightCm / 2.54;
        int feet = (int)(heightInches / 12);
        double inches = heightInches % 12;

        Console.WriteLine("Your Height in cm is " + heightCm + ", in feet is " + feet + ", and in inches is " + inches + ".");
    }
}
