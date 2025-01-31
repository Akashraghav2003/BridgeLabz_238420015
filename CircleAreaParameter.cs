using System;

class CircleAreaParameters
{
	double radius;
	
	//Create the constror to initialize the variables

	CircleAreaParameters(double radius)
	{
		this.radius=radius;
	}
	
	
	public double CalculateArea()
	{
		return 3.14*Math.Pow(radius,2);
	}
	
	public double CalculateCircumference()
	{
		return 2*3.14*radius;
	}
	//method to display the area and circumference of the circle
	public void Display()
	{
		
		Console.WriteLine("Area of Circle is: "+CalculateArea());
		Console.WriteLine("Circumference of Circle is: "+CalculateCircumference());
	}

	public static void Main()
	{
		Console.WriteLine("Enter the Radius of the circle: ");
		double radius = double.Parse(Console.ReadLine());
		//create class object
		Circle circle = new Circle(radius);
		circle.Display();
	}
	
}