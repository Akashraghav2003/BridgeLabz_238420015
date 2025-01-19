using System;

class PerimeterOfRectangle{
	static void Main(String [] args){
		
		Console.WriteLine("Enter the  length of rectangle: ");
		double length =Convert.ToDouble(Console.ReadLine());
	
		Console.WriteLine("Enter the  width of rectangle: ");
		double width =Convert.ToDouble(Console.ReadLine());
	
		double perimeter = 2*(length+width);
	
		Console.WriteLine("perimeter of re is : "+ perimeter);
		
	}
	
}