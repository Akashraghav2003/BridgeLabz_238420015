using System;

namespace Dynamic_Online_Marketplace
{
    public static class DiscountManager
    {
        public static void ApplyDiscount<T>(T product, double percentage) where T : IProduct
        {
            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine($"Discount Applied: {percentage}% - New Price of {product.Name}: ${product.Price:F2}");
        }
    }
}
