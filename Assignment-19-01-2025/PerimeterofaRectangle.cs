using System;
class PerimeterofaRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }
}
