using System;

namespace Assignments
{
    // Base class
    class Device
    {
        public string DeviceId { get; set; }
        public string Status { get; set; }

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
        }
    }

    // Subclass: Thermostat
    class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }

        public Thermostat(string deviceId, string status, double temperatureSetting) : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}, Temperature Setting: {TemperatureSetting}°C");
        }
    }

    class Class5
    {
        public static void Main5()
        {
            Device device = new Thermostat("89789", "offline", 52.8);
            device.DisplayStatus();
        }
    }
}
