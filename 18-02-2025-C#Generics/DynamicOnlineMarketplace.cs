using System;
using System.Collections.Generic;

// 1. Define category classes
public class BookCategory { }
public class ClothingCategory { }

// 2. Define a generic product class restricted to valid categories
public class Product<TCategory>
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Product: " + Name + ", Price: " + Price);
    }
}

// 3. Generic catalog class to manage products
public class ProductCatalog<TCategory>
{
    private List<Product<TCategory>> products = new List<Product<TCategory>>();

    public void AddProduct(Product<TCategory> product)
    {
        products.Add(product);
        Console.WriteLine(product.Name + " added to catalog.");
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("\nProducts in Catalog:");
        foreach (var product in products)
        {
            product.DisplayInfo();
        }
    }
}

// 4. Generic method to apply discount
public static class DiscountHelper
{
    public static void ApplyDiscount<TCategory>(Product<TCategory> product, double percentage)
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine("Discount applied! New price of " + product.Name + " is " + product.Price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create product catalog instances
        ProductCatalog<BookCategory> bookCatalog = new ProductCatalog<BookCategory>();
        ProductCatalog<ClothingCategory> clothingCatalog = new ProductCatalog<ClothingCategory>();

        // Create products
        Product<BookCategory> book1 = new Product<BookCategory>("C#", 50.00);
        Product<BookCategory> book2 = new Product<BookCategory>("Data Structures", 50.00);

        Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-Shirt", 20.00);
        Product<ClothingCategory> jeans = new Product<ClothingCategory>("Shirt", 30.00);

        // Add products to the catalog
        bookCatalog.AddProduct(book1);
        bookCatalog.AddProduct(book2);

        clothingCatalog.AddProduct(shirt);
        clothingCatalog.AddProduct(jeans);

        // Display catalog
        bookCatalog.DisplayAllProducts();
        clothingCatalog.DisplayAllProducts();

        // Apply discounts
        DiscountHelper.ApplyDiscount(book1, 10); 
        DiscountHelper.ApplyDiscount(jeans, 15);
        bookCatalog.DisplayAllProducts();
        clothingCatalog.DisplayAllProducts();
    }
}
