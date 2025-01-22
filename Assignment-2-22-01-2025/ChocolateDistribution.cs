using System;

class ChocolateDistribution {
    public static void Main(string[] args) {
        Console.WriteLine("Enter the number of chocolates and number of children:");
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());

        int eachGets = chocolates / children;
        int remaining = chocolates % children;

        Console.WriteLine("The number of chocolates each child gets is " + eachGets + " and the number of remaining chocolates is " + remaining);
    }
}
