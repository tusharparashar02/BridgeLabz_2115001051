using System;
using System.Collections.Generic;

namespace Assignments{
    class Product{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    //Order that contains multiple products
    class Order{
        public int OrderId { get; set; }
        public List<Product> Products { get; } = new List<Product>();
        public Customer1 Customer { get; set; } 
        public Order(int orderId, Customer1 customer)
        {
            OrderId = orderId;
            Customer = customer;
        }
        // Add a product to the order
        public void AddProduct(Product product){
            Products.Add(product);
        }
        // Display order details
        public void ShowOrderDetails()
        {
            Console.WriteLine("Order ID: " + OrderId + " for " + Customer.Name);
            Console.WriteLine("Products in order:");
            foreach (var product in Products)
            {
                Console.WriteLine("- " + product.Name + " ($" + product.Price + ")");
            }
            Console.WriteLine("*");
        }
    }
    class Customer1{
        public string Name { get; set; }
        public List<Order> Orders { get; } = new List<Order>();

        public Customer1(string name)
        {
            Name = name;
        }
        // Place an order
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }
        // Display customer's orders
        public void ShowOrders()
        {
            Console.WriteLine("Orders placed by " + Name + ":");
            foreach (var order in Orders)
            {
                Console.WriteLine("- Order ID: " + order.OrderId);
            }
            Console.WriteLine("*");
        }
    }
    // E-commerce Platform
    class EcommercePlatform
    {
        public string PlatformName { get; set; }
        public List<Customer1> Customers { get; } = new List<Customer1>();
        public List<Product> Products { get; } = new List<Product>();

        public EcommercePlatform(string platformName)
        {
            PlatformName = platformName;
        }

        // Add a customer to the platform
        public void AddCustomer(Customer1 customer)
        {
            if (!Customers.Contains(customer))
            {
                Customers.Add(customer);
            }
        }

        // Add a product to the platform
        public void AddProduct(Product product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }

        // Display available products
        public void ShowProducts()
        {
            Console.WriteLine("Available products on " + PlatformName + ":");
            foreach (var product in Products)
            {
                Console.WriteLine("- " + product.Name + " ($" + product.Price + ")");
            }
            Console.WriteLine("*");
        }
    }

    // Main program
    class main
    {
        public static void Main()
        {
            // Create an e-commerce platform instance
            EcommercePlatform myStore = new EcommercePlatform("MyStore");

            // Create product instances
            Product product1 = new Product("Product1", 1200.99m);
            Product product2 = new Product("Product2", 799.49m);

            // Add products to the platform
            myStore.AddProduct(product1);
            myStore.AddProduct(product2);

            // Create customer instances
            Customer1 customer1 = new Customer1("Customer1");
            Customer1 customer2 = new Customer1("Customer2");

            // Add customers to the platform
            myStore.AddCustomer(customer1);
            myStore.AddCustomer(customer2);

            // Create and place orders
            Order order1 = new Order(101, customer1);
            order1.AddProduct(product1);
            customer1.PlaceOrder(order1);

            Order order2 = new Order(102, customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product1);
            customer2.PlaceOrder(order2);

            // Display platform products
            myStore.ShowProducts();

            // Display customer orders
            customer1.ShowOrders();
            customer2.ShowOrders();

            // Display order details
            order1.ShowOrderDetails();
            order2.ShowOrderDetails();
        }
    }

}