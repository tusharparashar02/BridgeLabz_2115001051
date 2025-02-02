using System;
class Product
{
    public string productName {get; set;};
    public string price {get; set;};
    private static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        totalProducts++;
    }

    // Instance Method to Display Product Details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {ProductName}, Price: ${Price}");
    }

    // Class Method to Display Total Products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}