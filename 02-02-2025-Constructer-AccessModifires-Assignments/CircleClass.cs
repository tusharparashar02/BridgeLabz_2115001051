using System;
class Circle
{
    public double Radius { get; set; }

    // Default Constructor
    public Circle() : this(1.0) { }

    // Parameterized Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }
}