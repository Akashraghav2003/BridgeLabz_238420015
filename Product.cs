using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Product
    {
        public string productName { get; set; }
        public int price { get; set; }
        public static int totalProduct = 0;

        public Product(string productName, int price)
        {
            this.productName = productName;
            this.price = price;
            totalProduct++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}, Price: {price}");
        }

        public void DisplayTotalProducts()
        {
            Console.WriteLine($"Total product: {totalProduct}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the product name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(productName, price);

            product.DisplayProductDetails();

            Product product1 = new Product("samsung", 100);
            product1.DisplayProductDetails();
            product1.DisplayTotalProducts();
        }
    }
}
