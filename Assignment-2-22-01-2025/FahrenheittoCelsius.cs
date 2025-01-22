using System;

class FahrenheittoCelsius{
    public static void Main(string[] args) {
        Console.WriteLine("Enter temperature in Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine(fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }
}
