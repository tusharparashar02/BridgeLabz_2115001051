using System;

public class Vehicle
{
    public static decimal RegistrationFee = 5000;

    public readonly string RegistrationNumber;

    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
        RegistrationNumber = registrationNumber;
    }

    public static void UpdateRegistrationFee(decimal newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration Fee has been updated to: " + RegistrationFee);
    }

    public void DisplayRegistrationDetails()
    {
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
}

