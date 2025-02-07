using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatform
{
    internal class Ecommerce
    {
        private List<Customer> Customers;
        private List<Product> Products;
        private List<Order> Orders;

        public ECommercePlatform()
        {
            Customers = new List<Customer>();
            Products = new List<Product>();
            Orders = new List<Order>();
        }

        // Add Customer
        public void AddCustomer(string name, int id)
        {
            Customers.Add(new Customer(name, id));
        }

        // Add Product
        public void AddProduct(string name, int id, double price)
        {
            Products.Add(new Product(name, id, price));
        }

        // Place an Order
        public void PlaceOrder(int customerId, int orderId)
        {
            Customer customer = Customers.Find(c => c.CustomerID == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            Order order = customer.PlaceOrder(orderId);
            Orders.Add(order);

            Console.WriteLine("Enter product IDs to add to order (comma separated):");
            string[] productIds = Console.ReadLine().Split(',');

            foreach (string prodId in productIds)
            {
                int id = int.Parse(prodId);
                Product product = Products.Find(p => p.ProductID == id);
                if (product != null)
                    order.AddProduct(product);
                else
                    Console.WriteLine($"Product ID {id} not found.");
            }

            Console.WriteLine("Order placed successfully!");
        }

        // Display All Orders
        public void ShowOrders()
        {
            Console.WriteLine("\nAll Orders:");
            foreach (var order in Orders)
            {
                order.ShowOrderDetails();
            }
        }

        // Display All Customers
        public void ShowCustomers()
        {
            Console.WriteLine("\nCustomers:");
            foreach (var customer in Customers)
                customer.ShowCustomerDetails();
        }

        // Display All Products
        public void ShowProducts()
        {
            Console.WriteLine("\nAvailable Products:");
            foreach (var product in Products)
                product.ShowDetails();
        }
    }
}
