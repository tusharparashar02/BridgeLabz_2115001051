using System;
using System.Collections.Generic;

class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>();

    public void AddProduct(string product, double price)
    {
        productPrices[product] = price;
        sortedCart[product] = price;
    }
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.AddProduct("Laptop", 10000);
        cart.AddProduct("Mouse", 500);
        cart.AddProduct("Keyboard", 800);

        Console.WriteLine("Products in Cart:");
        foreach (KeyValuePair<string, double> item in cart.productPrices)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}
