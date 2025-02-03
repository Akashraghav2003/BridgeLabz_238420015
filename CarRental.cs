using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class CarRental
    {
        public string customerName { get; set; }
        public string carModel { get; set; }
        public int rentalDays { get; set; }

        public int dailyRate { get; set; }

        public CarRental(string customerNmae, string carModel, int rentalDays, int dailyRate)
        {
            this.customerName = customerNmae;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.dailyRate = dailyRate;
        }

        public double TotalCost(int rentalDays, int dailyRate)
        {
            return rentalDays * dailyRate;
        }

        public static void Main(string[] args)
        {


            Console.WriteLine("Enter the Car name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter the Car Model: ");
            string carModel = Console.ReadLine();
            Console.WriteLine("enter the rental Days: ");
            int rentelDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the daily rents: ");
            int dailyRate = Convert.ToInt32(Console.ReadLine());

            CarRental car = new CarRental(customerName, carModel, rentelDays, dailyRate);

            Console.WriteLine("Total rent of the car: " + car.TotalCost(rentelDays, dailyRate));
        }
    }
}
