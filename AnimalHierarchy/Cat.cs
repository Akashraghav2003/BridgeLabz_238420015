using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Cat : Animal
    {
        public Cat() : base("cat", 2)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name}  meows ");
        }
    }
}
