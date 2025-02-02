class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double TotalCost { get; private set; }
    private const double DailyRate = 100.0; 

    // Default Constructor
    public CarRental()
    {
        CustomerName = "Tushar Parashar";
        CarModel = "Brezza ZXI";
        RentalDays = 1;
        CalculateTotalCost();
    }
    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        CalculateTotalCost();
    }
    // Calculate Total Cost
    private void CalculateTotalCost()
    {
        TotalCost = RentalDays * DailyRate;
    }
}