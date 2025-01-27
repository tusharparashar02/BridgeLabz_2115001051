using System;

class CalculateWindChill
{
    public static double CalWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter temperature and wind speed:");
        double temperature = double.Parse(Console.ReadLine());
        double windSpeed = double.Parse(Console.ReadLine());
        Console.WriteLine("Wind Chill: " + CalWindChill(temperature, windSpeed));
    }
}