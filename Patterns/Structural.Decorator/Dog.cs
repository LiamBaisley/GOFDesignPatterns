using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class Dog: IDog
    {
        //We have a dog that can bark. But what if we want it to bark louder sometimes? 
        public string Bark()
        {
            return "bork!";
        }
    }
}
