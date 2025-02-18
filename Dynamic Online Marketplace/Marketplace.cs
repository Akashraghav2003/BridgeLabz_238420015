using System;
using System.Collections.Generic;

namespace Dynamic_Online_Marketplace
{
    public class Marketplace
    {
        private List<IProduct> catalog = new List<IProduct>(); // Stores multiple product types

        public void AddProduct<T>(Product<T> product) where T : ProductCategory
        {
            catalog.Add(product);
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("\n--- Product Catalog ---");
            foreach (var product in catalog)
            {
                product.DisplayProduct();
            }
        }
    }
}
