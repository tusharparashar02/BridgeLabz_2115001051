using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class InventoryManagement
    {
        public int ItemID;
        public string ItemName;
        public int Quantity;
        public double Price;
        public InventoryManagement Next;
        public InventoryManagement(int itemID, string itemName, int quantity, double price)
        {
            ItemID = itemID;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }
    class InventorylinkedList
    {
        private InventoryManagement head;

        public void AddItemAtBeginning(int itemID, string itemName, int quantity, double price)
        {
            InventoryManagement newItem = new InventoryManagement(itemID, itemName, quantity, price);

            if (head == null)
            {
                head = newItem;
                return;
            }

            newItem.Next = head;
            head = newItem;
        }

        public void AddItemAtEnd(int itemID, string itemName, int quantity, double price)
        {
            InventoryManagement newItem = new InventoryManagement(itemID, itemName, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            InventoryManagement temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newItem;
        }

        public void RemoveItem(int itemID)
        {
            if (head == null)
            {
                Console.WriteLine("no item found");
                return;
            }
            InventoryManagement temp = head;

            while (temp.Next != null)
            {
                if (temp.Next.ItemID == itemID)
                {
                    temp.Next = temp.Next.Next;
                    Console.WriteLine("item deleted ");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        public void UpdateQuantity(int itemID, int quantity)
        {
            InventoryManagement temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    temp.Quantity = quantity;
                    return;
                }
                temp = temp.Next;
            }
        }

        public void SearchItem(int itemID)
        {
            InventoryManagement temp = head;
            while (temp != null)
            {
                if (temp.ItemID == itemID)
                {
                    Console.WriteLine($"Item Found: {temp.ItemName}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            InventoryManagement temp = head;
            while (temp != null)
            {
                totalValue += temp.Quantity * temp.Price;
                temp = temp.Next;
            }
            return totalValue;
        }

        public void DisplayInventory()
        {
            InventoryManagement temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.ItemName}->");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public static void Main4()
        {
            InventorylinkedList inventory = new InventorylinkedList();
            inventory.AddItemAtBeginning(1, "Iphone", 20, 1000);
            inventory.AddItemAtEnd(2, "Samsung", 50, 20);
            inventory.AddItemAtEnd(3, "BlackBerry", 70, 50);

            Console.WriteLine("Inventory:");
            inventory.DisplayInventory();

            Console.WriteLine("\nTotal Inventory Value: " + inventory.CalculateTotalValue());

            Console.WriteLine("\nSearching for Item ID 2:");
            inventory.SearchItem(2);

            Console.WriteLine("\nUpdating Quantity of Item ID 1 to 5:");
            inventory.UpdateQuantity(1, 5);
            inventory.DisplayInventory();

            Console.WriteLine("\nRemoving Item ID 3:");
            inventory.RemoveItem(3);
            inventory.DisplayInventory();
        }
    }
}
