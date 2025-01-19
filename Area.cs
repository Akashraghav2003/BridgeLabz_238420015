using System;

class Area{
	static void Main (String [] Args){
		Console.WriteLine("Enter the length of radius of circle: ");
		double radius =Convert.ToDouble(Console.ReadLine());
		
		double area = 3.14 * radius*radius;
		
		Console.WriteLine("Area of circle is: " + area);
	}
}