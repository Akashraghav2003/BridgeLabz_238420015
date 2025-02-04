//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ShoppingCart
//{
//    internal class Product
//    {
//        // Static variable shared by all products
//        private static double Discount = 5.0; // Default discount 5%

//        // Readonly variable for unique Product ID
//        private readonly int ProductID;
//        private string ProductName;
//        private double Price;
//        private int Quantity;

//        // Constructor initializes Product ID
//        public Product()
//        {
//            this.ProductID = new Random().Next(1000, 9999); // Generate unique product ID
//        }

//        // Private method to get user input for product details
//        private void GetDetails()
//        {
//            Console.Write("Enter Product Name: ");
//            ProductName = Console.ReadLine();

//            Console.Write("Enter Product Price: ");
//            while (!double.TryParse(Console.ReadLine(), out Price) || Price < 0)
//            {
//                Console.Write("Invalid input! Enter a valid positive price: ");
//            }

//            Console.Write("Enter Product Quantity: ");
//            while (!int.TryParse(Console.ReadLine(), out Quantity) || Quantity <= 0)
//            {
//                Console.Write("Invalid input! Enter a valid positive quantity: ");
//            }
//        }

//        // Private method to display product details
//        private void DisplayProductDetails()
//        {
//            if (this is Product) // Using is operator to check instance
//            {
//                Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}, Price: {Price:C}, Quantity: {Quantity}");
//                Console.WriteLine($"Discount Applied: {Discount}%");
//                Console.WriteLine($"Total Price after Discount: {CalculateDiscountedPrice():C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid product instance.");
//            }
//        }

//        // Private method to calculate discounted price
//        private double CalculateDiscountedPrice()
//        {
//            double discountAmount = (Price * Discount) / 100;
//            return (Price - discountAmount) * Quantity;
//        }

//        // Static method to update the discount for all products
//        private static void UpdateDiscount(double newDiscount)
//        {
//            if (newDiscount >= 0 && newDiscount <= 100)
//            {
//                Discount = newDiscount;
//                Console.WriteLine($"Discount updated to {Discount}%");
//            }
//            else
//            {
//                Console.WriteLine("Invalid discount value. Enter a percentage between 0 and 100.");
//            }
//        }

//        // Public method to control private methods from outside
//        public void StartProductProcess()
//        {
//            GetDetails();
//            DisplayProductDetails();
//        }

//        // Public static method to allow modifying discount
//        public static void ChangeDiscount(double newDiscount)
//        {
//            UpdateDiscount(newDiscount);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Ask user how many products to enter
//            Console.Write("Enter the number of products you want to add: ");
//            int numProducts;
//            while (!int.TryParse(Console.ReadLine(), out numProducts) || numProducts <= 0)
//            {
//                Console.Write("Invalid input! Please enter a positive number: ");
//            }

//            Product[] products = new Product[numProducts];

//            // Creating products and taking input from user
//            for (int i = 0; i < numProducts; i++)
//            {
//                Console.WriteLine($"Enter details for Product {i + 1}:");
//                products[i] = new Product();
//                products[i].StartProductProcess();
//            }

//            // Option to update discount
//            Console.Write("Enter new discount percentage (or press Enter to skip): ");
//            string discountInput = Console.ReadLine();
//            if (!string.IsNullOrEmpty(discountInput) && double.TryParse(discountInput, out double newDiscount))
//            {
//                Product.ChangeDiscount(newDiscount);
//            }

//            // Display updated product details
//            Console.WriteLine("Updated Product Details:");
//            foreach (var product in products)
//            {
//                product.StartProductProcess();
//            }
//        }
//    }


//}
