using System;

namespace Assignments
{
    // Base class
    class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }

        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
        }
    }

    // Subclass: Car
    class Car : Vehicle
    {
        public int SeatCapacity { get; set; }

        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Seat Capacity: {SeatCapacity}");
        }
    }

    // Subclass: Truck
    class Truck : Vehicle
    {
        public int PayloadCapacity { get; set; }

        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Payload Capacity: {PayloadCapacity} kg");
        }
    }

    // Subclass: Motorcycle
    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Has Sidecar: {HasSidecar}");
        }
    }

    class Class3
    {
        public static void Main3()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
            new Car(450, "Petrol", 5),
            new Truck(850, "Diesel", 10520),
            new Motorcycle(520, "Petrol", true)
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }
}
