using System;
class TemperatureConverter{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.Write("Choose an option (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter temperature: ");
        double temperature = double.Parse(Console.ReadLine());
        if (choice == 1)
            Console.WriteLine("Temperature in Celsius: " + FahrenheitToCelsius(temperature));
        else if (choice == 2)
            Console.WriteLine("Temperature in Fahrenheit: " + CelsiusToFahrenheit(temperature));
        else
            Console.WriteLine("Invalid choice!");
    }
    static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
    static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
}