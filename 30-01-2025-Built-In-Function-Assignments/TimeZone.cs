using System;
class TimeZone
{
    static void Main(string[] args)
    {
        DateTimeOffset currTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine("GMT: " + currTime);

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currTime, istZone);
        Console.WriteLine("IST: " + istTime);
        
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currTime, pstZone);
        Console.WriteLine("PST: " + pstTime);
    }
}