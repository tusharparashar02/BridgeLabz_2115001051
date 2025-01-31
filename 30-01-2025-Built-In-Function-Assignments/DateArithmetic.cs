using System;
class DateArithmetic
{
    static void Main(string[] args){
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        newDate = newDate.AddDays(-21);
        Console.WriteLine("Updated Date: " + newDate.ToString("yyyy-MM-dd"));
    }
}