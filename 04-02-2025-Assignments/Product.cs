using System;

class Product
{
    private static double Discount = 0.0;
    private static int productCounter = 0;
    public readonly int ProductID;
    public string ProductName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string productName, double price, int quantity)
    {
        this.ProductID = ++productCounter;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public double GetDiscountedPrice()
    {
        return Price - (Price * Discount / 100);
    }

    public void DisplayProduct()
    {
        Console.WriteLine("Product ID: {ProductID}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Discounted Price: {GetDiscountedPrice():C}");
        Console.WriteLine($"Quantity: {Quantity}\n");
    }

    public static void ValidateProduct(object obj)
    {
        if (obj is Product product)
        {
            Console.WriteLine("The object is a valid Product instance.");
            product.DisplayProduct();
        }
        else
        {
            Console.WriteLine("Invalid Product object.");
        }
    }
}


