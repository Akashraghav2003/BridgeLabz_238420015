using EcommercePlatform;

class Program
{
    static void Main(string[] args)
    {
        Ecommerce platform = new Ecommerce();

        Console.Write("\nEnter number of Customers: ");
        int customerCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < customerCount; i++)
        {
            Console.Write($"Enter Customer {i + 1} Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Customer {i + 1} ID: ");
            int id = int.Parse(Console.ReadLine());
            platform.AddCustomer(name, id);
        }

        Console.Write("\nEnter number of Products: ");
        int productCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < productCount; i++)
        {
            Console.Write($"Enter Product {i + 1} Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Product {i + 1} ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"Enter Product {i + 1} Price: ");
            double price = double.Parse(Console.ReadLine());
            platform.AddProduct(name, id, price);
        }

        // Show Initial Data
        platform.ShowCustomers();
        platform.ShowProducts();

        while (true)
        {
            Console.Write("\nDo you want to place an order? (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes") break;

            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            platform.PlaceOrder(customerId, orderId);
        }

        // Show final orders
        platform.ShowOrders();
    }
}