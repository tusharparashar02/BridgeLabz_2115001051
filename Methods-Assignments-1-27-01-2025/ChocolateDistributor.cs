using System;

class ChocolateDistributor
{
    public static int[] DistributeChocolates(int numberOfChocolates, int numberOfChildren){
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        return new int[] { chocolatesPerChild, remainingChocolates };
    }

    static void Main(string[] args){
        Console.WriteLine("Enter number of chocolates and number of children:");
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());
        int[] result = DistributeChocolates(chocolates, children);
        Console.WriteLine("Chocolates per child: " + result[0]);
        Console.WriteLine(" Remaining: " + result[1]);
    }
}