using System;

class AreaofaCircle{
    public double Radius;
    public double GetArea(){
        return 3.14 * Radius * Radius;
    }
    public double GetCircumference(){
        return 2 * 3.14 * Radius;
    }
    static void Main(string[] args){
        AreaofaCircle circle = new AreaofaCircle();
        circle.Radius = 10;
        Console.WriteLine("Radius: " + circle.Radius);
        Console.WriteLine("Area: " + circle.GetArea());
        Console.WriteLine("Circumference: " + circle.GetCircumference());
    }
}
