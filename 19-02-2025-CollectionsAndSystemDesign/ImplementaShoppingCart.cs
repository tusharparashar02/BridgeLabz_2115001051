using System;
using System.Collections.Generic;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private LinkedList<string> cartOrder = new LinkedList<string>();
    private SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>();

    public void AddProduct(string product, double price)
    {
        productPrices[product] = price;
        sortedCart[product] = price;
        cartOrder.AddLast(product);
    }

    public void DisplayCart()
    {
        Console.WriteLine("Cart Items:");
        foreach (var item in productPrices)
            Console.WriteLine($"{item.Key}: ${item.Value}");
    }

    public void DisplaySortedCart()
    {
        Console.WriteLine("Cart Items Sorted by Price:");
        foreach (var item in sortedCart)
            Console.WriteLine($"{item.Key}: ${item.Value}");
    }

    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct("Laptop", 1000);
        cart.AddProduct("Mouse", 50);
        cart.AddProduct("Keyboard", 80);

        cart.DisplayCart();
        cart.DisplaySortedCart();
    }
}
