using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatform
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public double Price { get; set; }

        public Product(string name, int id, double price)
        {
            ProductName = name;
            ProductID = id;
            Price = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}, Price: ${Price}");
        }
    }
}
