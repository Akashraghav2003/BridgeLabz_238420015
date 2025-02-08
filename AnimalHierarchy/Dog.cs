using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Dog : Animal
    {
        public Dog() : base("Dog", 5) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} barks");
        }
    }
}
