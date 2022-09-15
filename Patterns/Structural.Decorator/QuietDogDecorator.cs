using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    internal class QuietDogDecorator: IDog
    {
        protected readonly IDog dog;

        public QuietDogDecorator(IDog dog)
        {
            this.dog = dog;
        }
        //Now we have a dog that can bark quietly sometimes. 
        public string Bark()
        {
            return "woof";
        }
    }
}
