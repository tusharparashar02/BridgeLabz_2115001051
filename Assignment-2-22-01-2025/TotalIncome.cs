using System;

class TotalIncome {
    public static void Main(string[] args) {
        Console.WriteLine("Enter salary and bonus:");
        double salary = double.Parse(Console.ReadLine());
        double bonus = double.Parse(Console.ReadLine());
        double totalIncome = salary + bonus;

        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
