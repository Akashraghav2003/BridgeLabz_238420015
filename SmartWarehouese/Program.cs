
using System;

namespace SmartWarehouese
{
	class Program
	{
        static void Main(string[] args)
        {
            Storage<Furniture> fur = new Storage<Furniture>();
            Storage<Groceries> groc = new Storage<Groceries>();
            Storage<Electronic> electronic = new Storage<Electronic>();
            while (true)
            {
                Console.WriteLine("Choose the operation: ");
                Console.WriteLine(" 1. add Furniture item \n 2.add groceries item \n 3. add electronic item \n 4. Dispplay all items. \n 5. Exits ");
                int oprtation = Convert.ToInt32(Console.ReadLine());

                switch(oprtation)
                {
                    case 1:
                        
                        Console.WriteLine("Enetr the name of product");
                        string name  = Console.ReadLine();
                        Console.WriteLine("Enetr the Price of product");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enetr the Brand : ");
                        string brand = Console.ReadLine();
                        electronic.AddItem(new Electronic(name, price, brand));
                        break;
                    case 2:
                        
                        Console.WriteLine("Enetr the name of product");
                        name = Console.ReadLine();
                        Console.WriteLine("Enetr the Price of product");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enetr the Expiary daet: ");
                        string date = Console.ReadLine();
                        DateOnly currentDate =DateOnly.Parse(date); 
                        groc.AddItem(new Groceries(name, price, currentDate));
                        break;
                    case 3:
                        
                        Console.WriteLine("Enetr the name of product");
                        name = Console.ReadLine();
                        Console.WriteLine("Enetr the Price of product");
                        price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enetr the Brand : ");
                        string material = Console.ReadLine();
                       
                        fur.AddItem(new Furniture(name, price, material));
                        break;
                    case 4:

                        Console.Write("\nDisplaying All Stored Items:");
                        Console.WriteLine("Electronics:");
                        electronic.Display();
                        Console.Write("Groceries:");
                        groc.Display();
                        Console.Write("Furniture:");
                        fur.Display();
                        break;
                    case 5:
                        return;


                    default:
                        Console.WriteLine("Choose the correct option: ");
                        break;
                }

            }
        }
    }
}