using System;

namespace Dynamic_Online_Marketplace
{
    public interface IProduct
    {
        string Name { get; }
        double Price { get; set; }
        void DisplayProduct();
    }

    public class Product<T> : IProduct where T : ProductCategory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"{Name} - Category: {Category.CategoryName}, Price: ${Price:F2}");
        }
    }
}
