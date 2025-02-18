using System;
using System.Collections.Generic;

// 1. Abstract class for warehouse items
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();
}

// 2. Derived classes for specific items
public class Electronics : WarehouseItem
{
    public int WarrantyYears { get; set; }

    public Electronics(string name, double price, int warrantyYears)
        : base(name, price)
    {
        WarrantyYears = warrantyYears;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("[Electronics] Name: " + Name + ", Price: " + Price + ", Warranty: " + WarrantyYears + " years");
    }
}

public class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, double price, DateTime expiryDate)
        : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("[Groceries] Name: " + Name + ", Price: " + Price + ", Expiry Date: " + ExpiryDate.ToShortDateString());
    }
}

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material)
        : base(name, price)
    {
        Material = material;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("[Furniture] Name: " + Name + ", Price: " + Price + ", Material: " + Material);
    }
}

// 3. Generic class for storage
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine(item.Name + " added to storage.");
    }

    public void DisplayAllItems()
    {
        Console.WriteLine("Items in Storage:");
        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    }
}
class Ware
{
    static void Main(string[] args)
    {
        // Create storage instances for different item types
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        // Add items
        electronicsStorage.AddItem(new Electronics("Laptop", 15000, 2));
        electronicsStorage.AddItem(new Electronics("phone", 5000, 1));

        groceriesStorage.AddItem(new Groceries("Parle ji", 10, DateTime.Now.AddDays(7)));
        groceriesStorage.AddItem(new Groceries("Bread", 15, DateTime.Now.AddDays(3)));

        furnitureStorage.AddItem(new Furniture("Sofa", 450.00, "Leather"));
        furnitureStorage.AddItem(new Furniture("Double Bed", 799.99, "Wood"));

        // Display stored items
        electronicsStorage.DisplayAllItems();
        groceriesStorage.DisplayAllItems();
        furnitureStorage.DisplayAllItems();
    }
}
