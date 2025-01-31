using System;

class EmployeeDetails
{	
	string name;
	string id;
	int salary;
	
	//Create the constror to initialize the variables
	EmployeeDetails(string name,string id,int salary)
	{
		this.name=name;
		this.id=id;
		this.salary=salary;
	}
	
	
	
	//method to display the Employee details
	public void Display()
	{
		Console.WriteLine("Name is: "+name);
		Console.WriteLine("Id is: "+id);
		Console.WriteLine("Salary: is "+salary);
	}

	public static void Main()
	{
		Console.WriteLine("Enter the Name of the Employee:");
		string name = Console.ReadLine();
		Console.WriteLine("Enter the Id of the Employee:");
		string id = Console.ReadLine();
		Console.WriteLine("Enter the Salary of the Employee: ");
		int salary = int.Parse(Console.ReadLine());
		
		Employee emp = new Employee(name,id,salary);
		emp.Display();
		
	}
	
}