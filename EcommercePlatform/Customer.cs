using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePlatform
{
    internal class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }
        private List<Order> Orders; // Aggregation: Customer has multiple orders

        public Customer(string name, int id)
        {
            CustomerName = name;
            CustomerID = id;
            Orders = new List<Order>();
        }

        // Place an Order
        public Order PlaceOrder(int orderId)
        {
            Order order = new Order(orderId, this);
            Orders.Add(order);
            return order;
        }

        // Display Customer Details
        public void ShowCustomerDetails()
        {
            Console.WriteLine($"\nCustomer ID: {CustomerID}, Name: {CustomerName}");
        }
    }
}
