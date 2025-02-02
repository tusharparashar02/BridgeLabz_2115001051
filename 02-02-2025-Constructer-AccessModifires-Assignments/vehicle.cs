class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    private static double RegistrationFee = 100.0; 
    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    // Instance Method to Display Vehicle Details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle: {VehicleType}, Registration Fee: ${RegistrationFee}");
    }

    // Class Method to Update Registration Fee
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }
}