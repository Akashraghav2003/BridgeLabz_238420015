using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    internal class ShopingCart
    {
        private Dictionary<string, double> productPrices = new Dictionary<string, double>();
        private LinkedList<string> cartOrder = new LinkedList<string>();
        private SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>();

        public void AddProduct(string product, double price)
        {
            productPrices[product] = price;
            sortedCart[product] = price;
            cartOrder.AddLast(product);
        }

        public void DisplayCart()
        {
            Console.WriteLine("\nCart in Order of Addition:");
            foreach (var product in cartOrder)
                Console.WriteLine($"{product}: ${productPrices[product]:0.00}");

            Console.WriteLine("\nCart Sorted by Price:");
            foreach (var item in sortedCart.OrderBy(x => x.Value))
                Console.WriteLine($"{item.Key}: ${item.Value:0.00}");
        }
    }
}
