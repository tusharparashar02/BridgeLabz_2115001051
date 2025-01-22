using System;

class EarthVolume {
    public static void Main(string[] args) {
        double radiusKm = 6378;
        double pi = 3.14159265359;
        double volumeKm = (4.0 / 3) * pi * Math.Pow(radiusKm, 3);
        double conversionFactor = 1.6;
        double volumeMiles = volumeKm / Math.Pow(conversionFactor, 3);

        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm + " and cubic miles is " + volumeMiles + ".");
    }
}
