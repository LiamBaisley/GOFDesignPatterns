using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    internal class Animal
    {
        public string Sound { get; set; }
        public bool RetractableClaws { get; set; }
        public bool CanFetch { get; set; }

        public void DescribePet()
        {
            Console.WriteLine($"This pet says: {Sound}");
            if (RetractableClaws)
                Console.WriteLine("This animal can retract its claws");
            else
                Console.WriteLine("This animal cannot retract its claws");

            if (CanFetch)
                Console.WriteLine("This animal can Fetch");
            else
                Console.WriteLine("This animal cannot Fetch");


        }
    }
}
