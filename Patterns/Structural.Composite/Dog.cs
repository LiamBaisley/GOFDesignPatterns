using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite
{
    internal class Dog
    {
        public string Name { get; set; }
        public List<IOffspring> Puppies = new List<IOffspring>();

        public void AddPuppy(string name, string color)
        {
            Puppies.Add(new Puppy(){Color = color, Name = name});
        }

        public void IntroduceSelfAndPuppies()
        {
            Console.WriteLine($"Hello, I am {Name} and these are my puppies");
            foreach (IOffspring puppy in Puppies)
            {
                puppy.DisplayDetails();
            }
        }
    }
}
