using System;

namespace Assignments
{
    // Base class
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public virtual string GetOrderStatus()
        {
            return "Order placed";
        }
    }

    // Subclass: ShippedOrder
    class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order shipped";
        }
    }

    // Subclass: DeliveredOrder
    class DeliveredOrder : ShippedOrder
    {
        public DateTime DeliveryDate { get; set; }

        public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        public override string GetOrderStatus()
        {
            return "Order delivered";
        }
    }

    class Class6
    {
        public static void Main6()
        {
            Order order = new Order(101, DateTime.Now);
            Order shippedOrder = new ShippedOrder(102, DateTime.Now, "Brezza45");
            Order deliveredOrder = new DeliveredOrder(103, DateTime.Now, "Brezza90", DateTime.Now.AddDays(3));

            Console.WriteLine($"Order ID: {order.OrderId}, Status: {order.GetOrderStatus()}");
            Console.WriteLine($"Order ID: {shippedOrder.OrderId}, Status: {shippedOrder.GetOrderStatus()}");
            Console.WriteLine($"Order ID: {deliveredOrder.OrderId}, Status: {deliveredOrder.GetOrderStatus()}");
        }
    }
}
