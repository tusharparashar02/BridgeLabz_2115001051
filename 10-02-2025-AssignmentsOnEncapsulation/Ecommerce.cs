using System;
using System.Collections.Generic;

abstract class Product
{
    protected int prodId;
    
    protected string name;
    
    protected double price;

    public int ProdId { get { return prodId; } set { prodId = value; } }
    
    public string Name { get { return name; } set { name = value; } }
    
    public double Price { get { return price; } set { price = value; } }

    public Product(int id, string n, double p)
    {
        prodId = id;
        name = n;
        price = p;
    }

    public abstract double CalculateDics();
}

interface ITaxable
{
    double CalcTax();
    
    string GetTaxDet();
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDics()
    {
        return price * 0.1;
    }

    public double CalcTax()
    {
        return price * 0.2;
    }

    public string GetTaxDet()
    {
        return "Electronics Tax: 20%";
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDics()
    {
        return price * 0.15;
    }

    public double CalcTax()
    {
        return price * 0.05;
    }

    public string GetTaxDet()
    {
        return "Clothing Tax: 5%";
    }
}

class Groceries : Product
{
    public Groceries(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDics()
    {
        return price * 0.05;
    }
}

class Program
{
    static void Main()
    {
        List<Product> prods = new List<Product>();
        
        prods.Add(new Electronics(1, "Windows", 1000));
        
        prods.Add(new Clothing(2, "Computer", 2000));
        
        prods.Add(new Groceries(3, "MAQBook", 3000));

        foreach (Product prod in prods)
        {
            double finalPrice = prod.Price + (prod is ITaxable t ? t.CalcTax() : 0) - prod.CalculateDics();
            
            Console.WriteLine("ID: " + prod.ProdId + ", Name: " + prod.Name + ", Final Price: " + finalPrice);
        }
    }
}