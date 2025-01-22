using System;

class CelsiustoFahrenheit {
    public static void Main(string[] args) {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(celsius + " Celsius is " + fahrenheit + " Fahrenheit");
    }
}
