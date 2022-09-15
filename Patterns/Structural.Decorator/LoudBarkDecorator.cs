using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class LoudBarkDecorator: IDog
    {
        protected readonly IDog dog;

        public LoudBarkDecorator(IDog dog)
        {
            this.dog = dog;
        }
        //Now we have a dog that can bark loudly sometimes. But what if we want it to bark quietly? 
        public string Bark()
        {
            return "BORK!!";
        }
    }
}
