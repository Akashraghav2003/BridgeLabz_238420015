using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public long mobNo { get; set; }

        public Person()
        {
            name = "akash singh";
            age = 21;
            mobNo = 8273932418;
        }

        public Person(Person other)
        {
            name = other.name;
            age = other.age;
            mobNo = other.mobNo;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, mobNo: {mobNo}");
        }

        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Display();

            Person person1 = new Person(person);
            person1.Display();
        }
    }
}
