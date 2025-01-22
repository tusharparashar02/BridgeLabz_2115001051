using System;

class FeeDiscountUserInput {
    public static void Main(string[] args) {
        Console.Write("Enter the fee amount: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discount = (discountPercent / 100) * fee;
        double discountedFee = fee - discount;
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + discountedFee + ".");
    }
}
