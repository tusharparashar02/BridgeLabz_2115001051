using System;

namespace Assignments
{
    // Interface for Refuelable vehicles
    interface IRefuelable
    {
        void Refuel();
    }

    // Base class
    class Vehicle1
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle1(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Model: {Model}, Max Speed: {MaxSpeed} km/h");
        }
    }

    // Subclass: ElectricVehicle
    class ElectricVehicle : Vehicle1
    {
        public int BatteryCapacity { get; set; }

        public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
            : base(model, maxSpeed)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electric Vehicle - Model: {Model}, Max Speed: {MaxSpeed} km/h, Battery Capacity: {BatteryCapacity} kWh");
        }

        public void Charge()
        {
            Console.WriteLine($"{Model} is charging.");
        }
    }

    // Subclass: PetrolVehicle
    class PetrolVehicle : Vehicle1, IRefuelable
    {
        public int FuelCapacity { get; set; }

        public PetrolVehicle(string model, int maxSpeed, int fuelCapacity)
            : base(model, maxSpeed)
        {
            FuelCapacity = fuelCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Petrol Vehicle - Model: {Model}, Max Speed: {MaxSpeed} km/h, Fuel Capacity: {FuelCapacity} L");
        }

        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling.");
        }
    }

    class Class11
    {
        public static void Main11()
        {
            Vehicle1 ev = new ElectricVehicle("Brezza ", 850, 105);
            Vehicle1 pv = new PetrolVehicle("Grand Vitara ", 940, 200);

            ev.DisplayInfo();
            ((ElectricVehicle)ev).Charge();

            pv.DisplayInfo();
            ((PetrolVehicle)pv).Refuel();
        }
    }
}
