//Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.

using System;

class TotalPrice
{
    static void Main()
    {
        // read user input for unit price of item
        Console.Write("Enter the unit price of the item (in INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
		//read the quantity of item 
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        // Calculate the total price
        double totalPrice = unitPrice * quantity;
        
        // display the result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and the unit price is INR " + unitPrice);
    }
}