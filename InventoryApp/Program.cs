using System;
using System.Collections.Generic;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool systemOn = true;
            while (systemOn == true)
            {
                Console.WriteLine("Welcome to your inventory app!");
                Console.WriteLine("Please enter one of five commands 'add' to add inventory, 'remove' to  delete inventory'");
                Console.WriteLine("'print' to print all items in your inventory and 'exit' to quit the app");
                string command = Console.ReadLine();

                if (command.ToLower() == "add")
                {

                }
            }
            Console.ReadLine();
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductPrice { get; set; }

        public Product(string name, int amount, decimal price)
        {
            ProductName = name;
            ProductAmount = amount;
            ProductPrice = price;
        }
        public void GetProductInfo(string name, int amount, decimal price)
        {
            Product newProduct = new Product();
            string productName = "";
            string productAmount = "";
            string productPrice = "";
            Console.WriteLine("Please enter your products name");
            productName = Console.ReadLine();
            Console.WriteLine("Please enter product amount.");
            productAmount = Console.ReadLine();
            Console.WriteLine("Please enter product price.");
            productPrice = Console.ReadLine();
        }
    }
    public class Inventory
    {
        public List<Product> InventoryList = new List<Product>();

        public Product AddProduct(Product product)
        {
            newProduct.GetProductInfo();
            InventoryList.Add(newProduct);
            Console.WriteLine(InventoryList.Count());
            return newProduct;
        }
        public void RemoveProduct()
        {

        }
        public void PrintAllProducts()
        {

        }
        public void UpdateProduct()
        {

        }
    }
}
