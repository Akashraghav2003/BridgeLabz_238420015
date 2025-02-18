using System;

namespace Dynamic_Online_Marketplace
{
    class Program
    {
        static void Main()
        {
            Marketplace marketplace = new Marketplace();

            // Create products
            var book = new Product<BookCategory>("C# Programming", 49.99, new BookCategory());
            var shirt = new Product<ClothingCategory>("Casual Shirt", 29.99, new ClothingCategory());

            // Add products to the catalog
            marketplace.AddProduct(book);
            marketplace.AddProduct(shirt);

            // Display Catalog Before Discount
            Console.WriteLine("\nBefore Discount:");
            marketplace.DisplayCatalog();

            // Apply Discounts
            DiscountManager.ApplyDiscount(book, 10); // 10% off on book
            DiscountManager.ApplyDiscount(shirt, 20); // 20% off on shirt

            // Display Updated Prices
            Console.WriteLine("\nAfter Discount:");
            marketplace.DisplayCatalog();
        }
    }
}
