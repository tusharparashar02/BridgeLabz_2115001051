using System;
using System.Collections.Generic;

abstract class FoodItem
{
    protected string itemName;
    
    protected double price;
    
    protected int quantity;

    public string ItemName { get { return itemName; } set { itemName = value; } }
    
    public double Price { get { return price; } set { price = value; } }
    
    public int Quantity { get { return quantity; } set { quantity = value; } }

    public FoodItem(string name, double p, int q)
    {
        itemName = name;
        price = p;
        quantity = q;
    }

    public abstract double CalcTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item: " + itemName + ", Price: " + price + ", Quantity: " + quantity);
    }
}

interface IDiscountable
{
    void ApplyDiscount(double percentage);
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double p, int q) : base(name, p, q) { }

    public override double CalcTotalPrice()
    {
        return price * quantity * 0.95; 
    }

    public void ApplyDiscount(double percentage)
    {
        price -= price * (percentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Veg item discount applied.";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double p, int q) : base(name, p, q) { }

    public override double CalcTotalPrice()
    {
        return price * quantity * 1.1; 
    }

    public void ApplyDiscount(double percentage)
    {
        price -= price * (percentage / 100);
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg item discount applied.";
    }
}

class Program
{
    static void Main()
    {
        List<FoodItem> items = new List<FoodItem>();
        
        items.Add(new VegItem("Paneer", 25.0, 8));
        
        items.Add(new NonVegItem("Roomali Roti", 12.0, 5));

        foreach (FoodItem item in items)
        {
            item.GetItemDetails();
            
            Console.WriteLine("Total Price: " + item.CalcTotalPrice() + "\n");
        }
    }
}