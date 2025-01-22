using System;

class TravelComputation {
    public static void Main(string[] args) {
        // Take user inputs for name and cities
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the starting city:");
        string fromCity = Console.ReadLine();

        Console.WriteLine("Enter the city en route:");
        string viaCity = Console.ReadLine();

        Console.WriteLine("Enter the destination city:");
        string toCity = Console.ReadLine();

        // Take user inputs for distances
        Console.WriteLine("Enter the distance from starting city to en route city (in km):");
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the distance from en route city to destination city (in km):");
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Take user inputs for travel times
        Console.WriteLine("Enter the time taken from starting city to en route city (in minutes):");
        int timeFromToVia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the time taken from en route city to destination city (in minutes):");
        int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());

        // Compute the total distance and total time
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;

        // Display the results
        Console.WriteLine("The Total Distance travelled by " + name + " from " + fromCity + " to " + toCity + " via " + viaCity + " is " + totalDistance + " km and the Total Time taken is " + totalTime + " minutes.");
    }
}
