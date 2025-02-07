using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatform
{
    internal class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; } // Association with Customer
        private List<Product> Products; // Aggregation with Products

        public Order(int orderId, Customer customer)
        {
            OrderID = orderId;
            Customer = customer;
            Products = new List<Product>();
        }

        // Add product to order
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Display Order Details
        public void ShowOrderDetails()
        {
            Console.WriteLine($"\nOrder ID: {OrderID}, Customer: {Customer.CustomerName}");
            Console.WriteLine("Products in this Order:");
            foreach (var product in Products)
            {
                product.ShowDetails();
            }
            Console.WriteLine($"Total Amount: ${CalculateTotal()}\n");
        }

        // Calculate Total Price of the Order
        private double CalculateTotal()
        {
            double total = 0;
            foreach (var product in Products)
                total += product.Price;
            return total;
        }
    }
}
