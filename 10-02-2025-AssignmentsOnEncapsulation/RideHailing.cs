using System;
using System.Collections.Generic;

abstract class Vehicle
{
    protected int vehicleId;
    
    protected string driverName;
    
    protected double ratePerKm;

    public int VehicleId { get { return vehicleId; } set { vehicleId = value; } }
    
    public string DriverName { get { return driverName; } set { driverName = value; } }
    
    public double RatePerKm { get { return ratePerKm; } set { ratePerKm = value; } }

    public Vehicle(int id, string d, double rate)
    {
        vehicleId = id;
        
        driverName = d;
        
        ratePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId + ", Driver: " + driverName + ", Rate/km: " + ratePerKm);
    }
}

interface IGPS
{
    string GetCurrentLocation();
    
    void UpdateLocation(string location);
}

class Car : Vehicle, IGPS
{
    public Car(int id, string d, double rate) : base(id, d, rate) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance * 1.2; 
    }

    public string GetCurrentLocation()
    {
        return "Car location: Downtown";
    }

    public void UpdateLocation(string location)
    {
        Console.WriteLine("Car location updated to: " + location);
    }
}

class Bike : Vehicle, IGPS
{
    public Bike(int id, string d, double rate) : base(id, d, rate) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance * 0.8; 
    }

    public string GetCurrentLocation()
    {
        return "Bike location: City Center";
    }

    public void UpdateLocation(string location)
    {
        Console.WriteLine("Bike location updated to: " + location);
    }
}

class Auto : Vehicle, IGPS
{
    public Auto(int id, string d, double rate) : base(id, d, rate) { }

    public override double CalculateFare(double distance)
    {
        return ratePerKm * distance;
    }

    public string GetCurrentLocation()
    {
        return "Auto location: Suburbs";
    }

    public void UpdateLocation(string location)
    {
        Console.WriteLine("Auto location updated to: " + location);
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        
        vehicles.Add(new Car(101, "Tushar", 50));
        
        vehicles.Add(new Bike(102, "Parashar", 60));
        
        vehicles.Add(new Auto(103, "GLA", 70));

        foreach (Vehicle veh in vehicles)
        {
            veh.GetVehicleDetails();
            
            Console.WriteLine("Fare for 10 km: " + veh.CalculateFare(10) + "\n");
        }
    }
}