//Create a program to calculate the profit and loss in number and percentage based on the cost price of INR 129 and the selling price of INR 191.

using System; //import System namespace for input and output

namespace Assignment{
	
	class ProfitOrLossCalculator{
		
		static void Main(){
			//Cost price of article
			int costPrice = 129;
			//Selling price of articles
			int sellingPrice = 191;
			
			//calculate the profit
			double profit = sellingPrice - costPrice;
			//calculate the profit percentage
			double  profitPer = (profit/costPrice)*100;
			
			//dispaly the result
			Console.WriteLine("The Cost Price is INR "+costPrice+" and Selling Price is INR "+sellingPrice);
			Console.WriteLine("The Profit is INR "+profit +" and the Profit Percentage is "+profitPer);
		}
	}
}