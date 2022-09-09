using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class Puppy: IOffspring
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"My name is {Name}");
            Console.WriteLine($"I Am {Color}");
        }
    }
}
