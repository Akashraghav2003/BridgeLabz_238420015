using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Bird : Animal
    {
        public Bird() : base ("Bird", 1)
        {

        } 

        public override void MakeSound()
        {
            Console.WriteLine($"{name} chrips");
        }
    }
}
