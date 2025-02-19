namespace Shopping_Cart
{
	class Program
	{

        static void Main()
        {
            ShopingCart cart = new ShopingCart();

            cart.AddProduct("Laptop", 1000);
            cart.AddProduct("Mouse", 50);
            cart.AddProduct("Keyboard", 75);
            cart.AddProduct("Monitor", 300);

            cart.DisplayCart();
        }
    }
}