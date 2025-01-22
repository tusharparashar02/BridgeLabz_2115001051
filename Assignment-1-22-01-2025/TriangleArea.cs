using System;

class TriangleArea {
    public static void Main(string[] args) {
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double areaCm = 0.5 * baseLength * height;
        double areaInches = areaCm / 6.452;
        Console.WriteLine("The area of the triangle is " + areaCm + " square cm and " + areaInches + " square inches.");
    }
}
