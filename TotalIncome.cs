using System; // Import System namespace

namespace Assignment2{
	
    class TotalIncome{
		
        static void Main(){
            //take salary from user
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine()); // Convert input to double

            //take bonus from user
            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine()); // Convert input to double

            // Calculate total income
            double totalIncome = salary + bonus;

            // Display the result
            Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
        }
    }
}
