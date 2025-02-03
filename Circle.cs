using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Circle
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            radius = 20.5;
        }

        public void Display()
        {
            Console.WriteLine($"the radius of circle: {radius}");
        }
        public static void Main(String[] args)
        {
            Circle c = new Circle();
            c.Display();
            Console.WriteLine("write the length of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle c2 = new Circle(radius);
            c2.Display();
        }
    }
}
