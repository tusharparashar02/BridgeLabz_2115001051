using System;
class LeapYear
{
    public static void Main(string[] args){
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());
        if (year < 1582){
            Console.WriteLine("Year must be >= 1582");
            return;
        }
        bool isLeap = IsLeapYear(year);
        if (isLeap)
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }
    public static bool IsLeapYear(int year){
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)){
            return true;
        }
        return false;
    }
}
