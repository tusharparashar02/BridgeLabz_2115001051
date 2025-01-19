using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
    }
}