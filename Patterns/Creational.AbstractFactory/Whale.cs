using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal class Whale : IAnimal
    {
        public string MakeSound()
        {
            return "OWOUOUOWHEOUOUO";
        }
    }
}
